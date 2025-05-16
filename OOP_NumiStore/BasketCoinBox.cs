using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_NumiStore.Models;

namespace OOP_NumiStore
{
    public partial class BasketCoinBox: UserControl
    {
        public BasketCoinBox()
        {
            InitializeComponent();
            selectedCountNumeric.TextChanged += selectedCountNumeric_TextChanged;
        }
        public CoinBase CoinBase { get; set; }

        [Category("Custom Props")]
        public string CoinTitle
        {
            get { return coinNameText.Text; }
            set { coinNameText.Text = value; }
        }

        [Category("Custom Props")]
        public string TypeCoin
        {
            set { coinTypeLabel.Text = $"{value}"; }
        }

        [Category("Custom Props")]
        public string SelectedCountCoin
        {
            set
            {
                decimal.TryParse(value, out decimal result);
                selectedCountNumeric.Value = result;
            }
        }

        [Category("Custom Props")]
        public string TotalPrice
        {
            set { resultLabel.Text = $"{value} грн."; }
        }

        private void selectedCountNumeric_TextChanged(object sender, EventArgs e)
        {
            decimal totalPrice = CoinBase.Price * selectedCountNumeric.Value;
            resultLabel.Text = $"{totalPrice} грн.";
        }
    }
}
