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
using System.Security.Cryptography;

namespace OOP_NumiStore
{
    public partial class BaseCoinBox : UserControl
    {
        public BaseCoinBox(User currentUser)
        {
            InitializeComponent();
            InitializeButtonsBlock(currentUser);
        }

        private void InitializeButtonsBlock(User currentUser)
        {
            customerPanelButtons.Visible = currentUser is Customer;
            adminPanelButtons.Visible = currentUser is Admin;
        }
        public MainAdminForm? MainAdminForm { get; set; } = null;

        public Coin Coin { get; set; }

        [Category("Custom Props")]
        public string CoinTitle
        {
            get { return coinTitle.Text; }
            set { coinTitle.Text = value; }
        }

        [Category("Custom props")]
        public string YearCoin
        {
            set { yearCoinText.Text = $"Рік: {value}"; }
        }

        [Category("Custom props")]
        public string CountryCoin
        {
            set { countryCoinText.Text = $"Країна: {value}"; }
        }

        [Category("Custom Props")]
        public string PriceCoin
        {
            //get { return priceCoinText.Text; }
            set { priceCoinText.Text = $"Ціна: {value} грн."; }
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
            get { return coinEditButton; }
            set { coinEditButton = value; }
        }

        private void coinEditButton_Click(object sender, EventArgs e)
        {
            EditCoinForm modalForm = new(Coin);
            modalForm.ShowDialog();
            if (modalForm.isSaved && MainAdminForm != null)
            {
                MainAdminForm.loadCoins();
                MainAdminForm.updateSearchAndFilterBlock();
            }
        }
    }
}
