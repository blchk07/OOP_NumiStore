using OOP_NumiStore.Models;

namespace OOP_NumiStore.Forms
{
    public partial class BasketForm: Form
    {
        List<BasketItem> basketItems;
        CoinsList coinsList = new CoinsList();
        public BasketForm()
        {
            InitializeComponent();
            basketItems = (UserSession.currentUser as Customer).Basket;

            foreach (var item in basketItems)
            {
                CoinBase? coinBase = coinsList.AllCoins.FirstOrDefault(c => c.Id == item.CoinId);
                if (coinBase != null) {
                    BasketCoinBox basketCoinBox = new BasketCoinBox
                    {
                        CoinBase = coinBase,
                        Width = basketItemsPanel.Width - 25,
                        CoinTitle = coinBase.Name,
                        TypeCoin = coinBase.Type,
                        SelectedCountCoin = item.Quantity.ToString(),
                        TotalPrice = (coinBase.Price * item.Quantity).ToString()
                    };
                    basketItemsPanel.Controls.Add(basketCoinBox);
                }
            }
        }
    }
}
