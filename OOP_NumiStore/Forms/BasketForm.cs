using OOP_NumiStore.Models;
using System.Text;
using System.Windows.Forms;

namespace OOP_NumiStore.Forms
{
    public partial class BasketForm : Form
    {
        List<BasketItem> basketItems;
        CoinsList coinsList = new CoinsList();
        Customer currentCustomer = UserSession.currentUser as Customer;
        UsersManager usersManager = new UsersManager();
        public bool isOrderCreated { get; private set; } = false;
        public BasketForm()
        {
            InitializeComponent();
            clearAllButton.Visible = currentCustomer.Basket.Count > 0;
            totalAmountLabel.Text = $"Сума: {CalcTotalAmount()} грн.";
            load_BasketItems();
        }

        private void load_BasketItems()
        {
            basketItemsPanel.Controls.Clear();

            basketItems = currentCustomer.Basket.ToList();
            basketItems.Reverse();

            foreach (var item in basketItems)
            {
                CoinBase? coinBase = coinsList.AllCoins.FirstOrDefault(c => c.Id == item.CoinId);
                if (coinBase != null)
                {
                    BasketCoinBox basketCoinBox = new BasketCoinBox(coinBase)
                    {
                        BasketItem = item,
                        Width = basketItemsPanel.Width - 25,
                        CoinTitle = coinBase.Name,
                        TypeCoin = coinBase.Type,
                        CoinImagePath = coinBase.ImagePath,
                        SelectedCountCoin = item.Quantity.ToString(),
                        TotalPrice = (coinBase.Price * item.Quantity).ToString()
                    };
                    basketCoinBox.DeleteBasketItem += deleteBasketItem;
                    basketCoinBox.ChangeCount += changeTotalAmount;
                    basketCoinBox.ChangeCount += saveCount;
                    basketItemsPanel.Controls.Add(basketCoinBox);
                }
                else
                {
                    currentCustomer.DeleteBasketItem(item);
                    usersManager.UpdateCustomers(currentCustomer);
                }
            }

            if (basketItems.Count == 0)
            {
                Label noItemsLabel = new Label
                {
                    Text = "Кошик пустий",
                    AutoSize = true,
                    Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                    Margin = new Padding(220, 150, 0, 0),
                };

                basketItemsPanel.Controls.Add(noItemsLabel);
                createOrderButton.Visible = currentCustomer.Basket.Count > 0;
                return;
            }
        }

        private void deleteBasketItem(object sender, BasketItem BasketItem)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете видалити цю монету з кошика?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentCustomer.DeleteBasketItem(BasketItem);
                usersManager.UpdateCustomers(currentCustomer);
                load_BasketItems();
                changeTotalAmount();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете очистити весь кошик?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                currentCustomer.ClearBasket();
                usersManager.UpdateCustomers(currentCustomer);
                clearAllButton.Visible = false;
                totalAmountLabel.Text = $"Сума: 0 грн.";
                load_BasketItems();
            }
        }

        private void saveCount(object sender, BasketItem BasketItem)
        {
            currentCustomer.EditBasketItem(BasketItem);
            usersManager.UpdateCustomers(currentCustomer);
        }

        private int CalcTotalAmount()
        {
            int total = 0;
            basketItems = currentCustomer.Basket;
            if (basketItems != null)
            {
                foreach (var item in basketItems)
                {
                    CoinBase? coinBase = coinsList.AllCoins.FirstOrDefault(c => c.Id == item.CoinId);
                    if (coinBase != null)
                    {
                        total += (int)(coinBase.Price * item.Quantity);
                    }
                }
            }
            return total;
        }

        private void changeTotalAmount(object? sender = null, BasketItem? BasketItem = null)
        {
            totalAmountLabel.Text = $"Сума: {CalcTotalAmount()} грн.";
        }

        private string GenerateCheckText(Order order)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("===== ЧЕК =====");
            sb.AppendLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            sb.AppendLine($"Номер замовлення: {order.OrderId}");
            sb.AppendLine();
            sb.AppendLine("Товари:");
            sb.AppendLine("-------------------------------------");

            foreach (var item in order.Items)
            {
                sb.AppendLine($"{item.Name}");
                sb.AppendLine($"Кількість: {item.Quantity} шт");
                sb.AppendLine($"Ціна за шт: {item.Price} грн");
                sb.AppendLine($"Сума: {item.Total} грн");
                sb.AppendLine();
            }

            sb.AppendLine("-------------------------------------");
            sb.AppendLine($"Загальна сума: {order.TotalAmount} грн");
            sb.AppendLine("===== Дякуємо за покупку! =====");

            return sb.ToString();
        }


        private void SaveCheckToFile(string checkText)
        {
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Checks");
            Directory.CreateDirectory(directory);

            string fileName = $"check_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string filePath = Path.Combine(directory, fileName);

            File.WriteAllText(filePath, checkText);
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви впевнені, що хочете оформити замовлення?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            List<OrderedCoin> orderedCoins = new List<OrderedCoin>();

            foreach (var item in currentCustomer.Basket)
            {
                CoinBase? coinBase = coinsList.AllCoins.FirstOrDefault(c => c.Id == item.CoinId);
                if (coinBase != null)
                {
                    OrderedCoin orderedCoin = new OrderedCoin
                    {
                        CoinId = coinBase.Id,
                        Name = coinBase.Name,
                        Type = coinBase.Type,
                        Year = coinBase.Year,
                        Material = coinBase.Material,
                        Price = coinBase.Price,
                        ImagePath = coinBase.ImagePath,
                        Quantity = item.Quantity
                    };
                    orderedCoins.Add(orderedCoin);
                    coinBase.AvailableCount -= item.Quantity;
                    coinsList.EditCoin(coinBase);
                }
            }

            Order order = new Order
            {
                CustomerLogin = currentCustomer.Login,
                Items = orderedCoins
            };

            OrdersManager ordersManager = new OrdersManager();
            ordersManager.AddOrder(order);

            currentCustomer.ClearBasket();
            usersManager.UpdateCustomers(currentCustomer);

            var checkText = GenerateCheckText(order);
            SaveCheckToFile(checkText);

            isOrderCreated = true;
            Close();
        }
    }
}
