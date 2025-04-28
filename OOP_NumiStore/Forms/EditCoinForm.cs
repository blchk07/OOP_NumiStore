using OOP_NumiStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_NumiStore.Forms
{
    public partial class EditCoinForm : Form
    {
        public bool isSaved { get; private set; } = false;
        public EditCoinForm(Coin coin)
        {
            InitializeComponent();
            currentCoin = coin;
            coinIdTextBox.Text = Convert.ToString(coin.Id);
            coinNameTextBox.Text = coin.Name;
            coinYearTextBox.Text = Convert.ToString(coin.Year);
            coinMaterialComboBox.Text = coin.Material;
            coinMaterialComboBox.Items.AddRange(CoinSettings.coinMaterials.ToArray());
            coinPriceTextBox.Text = Convert.ToString(coin.Price);
            coinAvaiableCountTextBox.Text = Convert.ToString(coin.AvailableCount);
            coinCountryComboBox.Text = coin.Country;
            coinCountryComboBox.Items.AddRange(CoinSettings.coinCountries.ToArray());
            coinDenominationTextBox.Text = Convert.ToString(coin.Denomination);
            coinDiametrTextBox.Text = Convert.ToString(coin.Diameter);
            coinSeriesComboBox.Text = coin.Series;
            coinDescriptionTextBox.Text = coin.Description;
        }

        private Coin currentCoin { get; set; }

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

            currentCoin.Name = coinNameTextBox.Text.Trim();
            currentCoin.Year = year;
            currentCoin.Material = coinMaterialComboBox.Text.Trim();
            currentCoin.Price = price;
            currentCoin.AvailableCount = availableCount;
            currentCoin.Country = coinCountryComboBox.Text.Trim();
            currentCoin.Denomination = denomination;
            currentCoin.Diameter = diameter;
            currentCoin.Series = coinSeriesComboBox.Text.Trim();
            currentCoin.Description = coinDescriptionTextBox.Text.Trim();

            isSaved = true;
            MessageBox.Show("Зміни збережено!", "Успішна зміна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
