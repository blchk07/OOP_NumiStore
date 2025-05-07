using OOP_NumiStore.Models;
using System.Data;

namespace OOP_NumiStore.Forms
{
    public partial class CreateCoinForm : Form
    {
        public CreateCoinForm()
        {
            InitializeComponent();
            InitializeForm();
        }
        public void InitializeForm()
        {
            coinMaterialComboBox.Items.AddRange(CoinSettings.coinMaterials.ToArray());
            coinCountryComboBox.Items.AddRange(CoinSettings.coinCountries.ToArray());

            CoinsList coinsList = new CoinsList();
            Array avaiableSeries = coinsList.Coins.Select(c => c.Series).Distinct().ToArray();

            if (avaiableSeries.Length > 0)
            {
                coinSeriesComboBox.Items.AddRange(coinsList.Coins.Select(c => c.Series).Distinct().ToArray());
            }
            else
            {
                coinSeriesComboBox.DropDownStyle = ComboBoxStyle.Simple;
            }
        }

        public Coin newCoin { get; } = new Coin();

        public bool isCreated { get; private set; } = false;

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

            if (string.IsNullOrWhiteSpace(coinCountryComboBox.Text))
            {
                MessageBox.Show("Будь ласка, виберіть або введіть країну!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (!int.TryParse(coinDenominationTextBox.Text, out int denomination) || denomination <= 0)
            {
                MessageBox.Show("Номінал має бути додатним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(coinDiametrTextBox.Text, out double diameter) || diameter <= 0)
            {
                MessageBox.Show("Діаметр має бути додатним числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newCoin.Name = coinNameTextBox.Text.Trim();
            newCoin.Year = year;
            newCoin.Material = coinMaterialComboBox.Text.Trim();
            newCoin.Price = price;
            newCoin.AvailableCount = availableCount;
            newCoin.Country = coinCountryComboBox.Text.Trim();
            newCoin.Denomination = denomination;
            newCoin.Diameter = diameter;
            newCoin.Series = coinSeriesComboBox.Text.Trim();
            newCoin.Description = coinDescriptionTextBox.Text.Trim();

            isCreated = true;

            MessageBox.Show("Монета створена успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
