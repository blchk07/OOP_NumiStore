using OOP_NumiStore.Models;
using System.Data;
using System.Windows.Forms;

namespace OOP_NumiStore.Forms
{
    public partial class CreateCoinForm : Form
    {
        private bool isRegularCoin = true;
        private string tempImagePath = null;

        public CreateCoinForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        public void InitializeForm()
        {
            coinMaterialComboBox.Items.AddRange(CoinSettings.coinMaterials.ToArray());

            CoinsList coinsList = new CoinsList();
            var availableSeries = coinsList.AllCoins.Select(c => c.Series).Distinct().ToArray();

            if (availableSeries.Length > 0)
            {
                coinSeriesComboBox.Items.AddRange(availableSeries);
            }
            else
            {
                coinSeriesComboBox.DropDownStyle = ComboBoxStyle.Simple;
            }
            regularCoinRadioButton.Checked = true;

            coinPictureBox.AllowDrop = true;
            coinPictureBox.DragEnter += coinPictureBox_DragEnter;
            coinPictureBox.DragDrop += coinPictureBox_DragDrop;
        }

        public CoinBase newCoin { get; private set; }
        public bool isCreated { get; private set; } = false;

        private int SetUniqueId()
        {
            CoinsList coinsList = new CoinsList();
            const string idFilePath = "max_id.txt";

            int maxIdFromFile = 0;
            if (File.Exists(idFilePath))
            {
                string fileContent = File.ReadAllText(idFilePath);
                if (int.TryParse(fileContent, out int parsedId))
                {
                    maxIdFromFile = parsedId;
                }
            }

            int maxIdFromList = coinsList.AllCoins.Any() ? coinsList.AllCoins.Max(c => c.Id) : 0;
            int maxId = Math.Max(maxIdFromFile, maxIdFromList);
            int newId = maxId + 1;
            File.WriteAllText(idFilePath, newId.ToString());

            return newId;
        }

        private void createCoinButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(coinNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Назва монети не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(coinMaterialComboBox.Text))
            {
                MessageBox.Show("Будь ласка, виберіть або введіть матеріал!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(coinYearTextBox.Text, out int year) || year < 0 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Рік має бути числом від 0 до {DateTime.Now.Year}!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(coinPriceTextBox.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Ціна має бути додатним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(coinAvaiableCountTextBox.Text, out int availableCount) || availableCount < 0)
            {
                MessageBox.Show("Кількість доступних монет має бути невід’ємним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(coinDiametrTextBox.Text, out double diameter) || diameter <= 0)
            {
                MessageBox.Show("Діаметр має бути додатним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (isRegularCoin)
            {
                if (!int.TryParse(coinDenominationTextBox.Text, out int denomination) || denomination <= 0)
                {
                    MessageBox.Show("Номінал має бути додатним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                newCoin = new RegularCoin { Denomination = denomination };
            }
            else
            {
                newCoin = new CollectibleCoin();
            }

            if (string.IsNullOrEmpty(tempImagePath))
            {
                MessageBox.Show("Будь ласка, виберіть зображення монети!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newCoin.Id = SetUniqueId();
            newCoin.Name = coinNameTextBox.Text.Trim();
            newCoin.Year = year;
            newCoin.Material = coinMaterialComboBox.Text.Trim();
            newCoin.Price = price;
            newCoin.AvailableCount = availableCount;
            newCoin.Diameter = diameter;
            newCoin.Series = coinSeriesComboBox.Text.Trim();
            newCoin.Description = coinDescriptionTextBox.Text.Trim();

            string imageDirectory = Path.Combine(Application.StartupPath, "Images");
            Directory.CreateDirectory(imageDirectory);
            string newImagePath = Path.Combine(imageDirectory, Guid.NewGuid() + Path.GetExtension(tempImagePath));
            File.Copy(tempImagePath, newImagePath, overwrite: true);
            newCoin.ImagePath = newImagePath;

            isCreated = true;

            MessageBox.Show("Монета створена успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void regularCoinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            isRegularCoin = regularCoinRadioButton.Checked;
            coinDenominationTextBox.Enabled = isRegularCoin;

            if (!isRegularCoin)
            {
                coinDenominationTextBox.Text = "";
            }
        }

        private void coinPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string file = files[0].ToLower();

                if (file.EndsWith(".jpg") || file.EndsWith(".jpeg") ||
                    file.EndsWith(".png") ||
                    file.EndsWith(".webp"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    MessageBox.Show("Будь ласка, виберіть зображення формату JPG, JPEG, або PNG", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void coinPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                var file = files[0];
                coinPictureBox.Image = Image.FromFile(file);
                tempImagePath = file;
            }
        }
    }
}
