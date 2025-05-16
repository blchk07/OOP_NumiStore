using System.ComponentModel;
using OOP_NumiStore.Models;
using OOP_NumiStore.Forms;

namespace OOP_NumiStore
{
    public partial class BaseCoinBox : UserControl
    {
        public event EventHandler<CoinBase> EditCoinButtonClicked;
        public event EventHandler<CoinBase> DeleteCoinButtonClicked;
        public event EventHandler<CoinBase> CoinDetailsButtonClicked;
        public event EventHandler<CoinBase> CoinBasketButtonClicked;
        public BaseCoinBox(User currentUser)
        {
            InitializeComponent();
            InitializeButtonsBlock(currentUser);
        }

        private void InitializeButtonsBlock(User currentUser)
        {
            adminPanelButtons.Visible = currentUser is Admin;
            customerPanelButtons.Visible = currentUser is Customer;
        }

        public CoinBase Coin { get; set; }

        [Category("Custom Props")]
        public string CoinTitle
        {
            get { return coinTitle.Text; }
            set { coinTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string TypeCoin
        {
            set { typeCoinText.Text = $"Тип: {value}"; }
        }

        [Category("Custom Props")]
        public string AvailableCountCoin
        {
            set { availableCountText.Text = $"Кількість: {value} шт."; }
        }

        [Category("Custom props")]
        public string YearCoin
        {
            set { yearCoinText.Text = $"Рік: {value}"; }
        }

        [Category("Custom Props")]
        public string PriceCoin
        {
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
            EditCoinButtonClicked?.Invoke(this, Coin);
        }

        private void coinDeleteButton_Click(object sender, EventArgs e)
        {
            DeleteCoinButtonClicked?.Invoke(this, Coin);
        }

        private void coinDetailsButton_Click(object sender, EventArgs e)
        {
            CoinDetailsButtonClicked?.Invoke(this, Coin);
        }

        private void coinBasketButton_Click(object sender, EventArgs e)
        {
            CoinBasketButtonClicked?.Invoke(this, Coin);
        }
    }
}
