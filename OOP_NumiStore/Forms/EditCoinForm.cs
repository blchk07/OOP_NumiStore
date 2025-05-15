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
            coinDescriptionTextBox.Text = coin.Description;

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

            currentCoin.Name = coinNameTextBox.Text.Trim();
            currentCoin.Year = year;
            currentCoin.Material = coinMaterialComboBox.Text.Trim();
            currentCoin.Price = price;
            currentCoin.AvailableCount = availableCount;
            currentCoin.Diameter = diameter;
            currentCoin.Series = coinSeriesComboBox.Text.Trim();
            currentCoin.Description = coinDescriptionTextBox.Text.Trim();

            isSaved = true;
            MessageBox.Show("Зміни збережено!", "Успішна зміна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
