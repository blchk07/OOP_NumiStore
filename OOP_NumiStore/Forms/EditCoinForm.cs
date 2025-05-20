using OOP_NumiStore.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OOP_NumiStore.Forms
{
    public partial class EditCoinForm : Form
    {
        public bool isSaved { get; private set; } = false;
        private CoinBase currentCoin { get; set; }
        CoinsList coinsList = new CoinsList();
        private string tempImagePath = string.Empty;

        public EditCoinForm(CoinBase coin)
        {
            InitializeComponent();
            currentCoin = coin;

            typeCoinLabel.Text += coin.Type;
            coinIdTextBox.Text = coin.Id.ToString();
            coinNameTextBox.Text = coin.Name;
            coinYearTextBox.Text = coin.Year.ToString();
            coinMaterialComboBox.Items.AddRange(CoinSettings.coinMaterials.ToArray());
            coinMaterialComboBox.Text = coin.Material;
            coinPriceTextBox.Text = coin.Price.ToString();
            coinAvaiableCountTextBox.Text = coin.AvailableCount.ToString();
            coinDiametrTextBox.Text = coin.Diameter.ToString();
            coinSeriesComboBox.Text = coin.Series;
            var seriesList = coinsList.AllCoins.Select(c => c.Series).Distinct().ToArray();
            coinSeriesComboBox.Items.AddRange(seriesList);
            coinDescriptionTextBox.Text = coin.Description;
            tempImagePath = coin.ImagePath;

            coinPictureBox.AllowDrop = true;
            coinPictureBox.DragEnter += coinPictureBox_DragEnter;
            coinPictureBox.DragDrop += coinPictureBox_DragDrop;

            if (coin is RegularCoin regular)
            {
                coinDenominationTextBox.Text = regular.Denomination.ToString();
                coinDenominationTextBox.Enabled = true;
            }
            else
            {
                coinDenominationTextBox.Text = "";
                coinDenominationTextBox.Enabled = false;
            }

            if (!string.IsNullOrEmpty(currentCoin.ImagePath) && File.Exists(currentCoin.ImagePath))
            {
                try
                {
                    coinPictureBox.Image = Image.FromFile(currentCoin.ImagePath);
                    coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch
                {
                    coinPictureBox.Image = null;
                }
            }
            else
            {
                coinPictureBox.Image = null;
            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
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

            if (currentCoin is RegularCoin regularCoin)
            {
                if (!int.TryParse(coinDenominationTextBox.Text, out int denomination) || denomination <= 0)
                {
                    MessageBox.Show("Номінал має бути додатним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                regularCoin.Denomination = denomination;
            }

            if (string.IsNullOrEmpty(tempImagePath))
            {
                MessageBox.Show("Будь ласка, виберіть зображення монети!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            currentCoin.Name = coinNameTextBox.Text.Trim();
            currentCoin.Year = year;
            currentCoin.Material = coinMaterialComboBox.Text.Trim();
            currentCoin.Price = price;
            currentCoin.AvailableCount = availableCount;
            currentCoin.Diameter = diameter;
            currentCoin.Series = coinSeriesComboBox.Text.Trim();
            currentCoin.Description = coinDescriptionTextBox.Text.Trim();

            string imageDirectory = Path.Combine(Application.StartupPath, "Images");
            Directory.CreateDirectory(imageDirectory);
            string newImagePath = Path.Combine(imageDirectory, Guid.NewGuid() + Path.GetExtension(tempImagePath));
            File.Copy(tempImagePath, newImagePath, overwrite: true);
            currentCoin.ImagePath = newImagePath;

            isSaved = true;
            MessageBox.Show("Зміни збережено!", "Успішна зміна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
                    MessageBox.Show("Будь ласка, виберіть зображення формату JPG, JPEG, WEBP або PNG", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
