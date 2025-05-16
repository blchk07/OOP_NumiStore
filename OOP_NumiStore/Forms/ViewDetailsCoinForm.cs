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
    public partial class ViewDetailsCoinForm: Form
    {
        public ViewDetailsCoinForm(CoinBase currentCoin)
        {
            InitializeComponent();

            if (currentCoin is RegularCoin regular) coinDenominationTextBox.Text = regular.Denomination.ToString();

            typeCoinLabel.Text += currentCoin.Type;
            coinIdTextBox.Text = currentCoin.Id.ToString();
            coinNameTextBox.Text = currentCoin.Name;
            coinYearTextBox.Text = currentCoin.Year.ToString();
            coinMaterialTextBox.Text = currentCoin.Material;
            coinPriceTextBox.Text = currentCoin.Price.ToString();
            coinAvaiableCountTextBox.Text = currentCoin.AvailableCount.ToString();
            coinDiametrTextBox.Text = currentCoin.Diameter.ToString();
            coinSeriesTextBox.Text = currentCoin.Series;
            coinDescriptionTextBox.Text = currentCoin.Description;
        }
    }
}
