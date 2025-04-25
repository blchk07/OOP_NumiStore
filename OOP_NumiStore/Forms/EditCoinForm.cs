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

namespace OOP_NumiStore.Forms
{
    public partial class EditCoinForm : Form
    {
        public EditCoinForm(Coin coin)
        {
            InitializeComponent();
            currentCoin = coin;
            coinIdTextBox.Text = Convert.ToString(coin.Id);
            coinNameTextBox.Text = coin.Name;
            coinYearTextBox.Text = Convert.ToString(coin.Year);
            coinMaterialTextBox.Text = coin.Material;
            coinPriceTextBox.Text = Convert.ToString(coin.Price);
            coinAvaiableCountTextBox.Text = Convert.ToString(coin.AvailableCount);
            coinCountryTextBox.Text = coin.Country;
            coinDenominationTextBox.Text = Convert.ToString(coin.Denomination);
            coinDiametrTextBox.Text = Convert.ToString(coin.Diameter);
            coinSeriesTextBox.Text = coin.Series;
            coinDescriptionTextBox.Text = coin.Description;
        }

        private Coin currentCoin { get; set; }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (coinNameTextBox.Text.Trim() != currentCoin.Name.Trim())
            {
                currentCoin.Name = coinNameTextBox.Text.Trim();
            }
        }
    }
}
