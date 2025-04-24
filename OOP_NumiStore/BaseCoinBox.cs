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
using OOP_NumiStore.Forms;

namespace OOP_NumiStore
{
    public partial class BaseCoinBox : UserControl
    {
        public BaseCoinBox()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public string CoinTitle
        {
            get { return coinTitle.Text; }
            set { coinTitle.Text = value; }
        }
        public Coin Coin { get; set; }

        [Category("Custom Props")]
        public string PriceCoin
        {
            get { return priceCoin.Text; }
            set { priceCoin.Text = value; }
        }
        [Category("Custom Props")]
        public Image CoinImage
        {
            get { return pictureCoin.Image; }
            set { pictureCoin.Image = value; }
        }
        [Category("Custom Props")]
        public Button CoinDetailButton
        {
            get { return coinDetailButton; }
            set { coinDetailButton = value; }
        }

        private void coinDetailButton_Click(object sender, EventArgs e)
        {
            EditCoinForm modalForm = new (Coin);
            modalForm.ShowDialog();
        }
    }
}
