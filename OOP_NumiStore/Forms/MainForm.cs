using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOP_NumiStore.Models;

namespace OOP_NumiStore.Forms
{
    public partial class MainForm : Form
    {
        public CoinsList CoinList { get; private set; } = new CoinsList();
        User currentUser { get; set; }
        static ToolTip toolTip = new();

        public MainForm()
        {
            currentUser = UserSession.currentUser;
            InitializeComponent();
            userLoginLinkLabel.Text = $"{currentUser.Name} {currentUser.Surname}".Trim();
            toolTip.SetToolTip(userLoginLinkLabel, "Налаштування акаунту");

            this.Text = currentUser is Customer ? "NumiStore - Головна сторінка" : "Адмін NumiStore - Головна сторінка";
            createNewCoinButton.Visible = currentUser is Admin;

            if (currentUser is Admin)
            {
                button1.Text = "Замовлення";
                button1.Click += ordersAdminButtonClick;
                button2.Visible = false;
            }
            else if (currentUser is Customer)
            {
                button1.Text = "Кошик";
                button1.Click += basketCustomerButtonClick;
                button2.Visible = true;
                button2.Text = "Замовлення";
                button2.Click += ordersCustomerButtonClick;
            }

            loadCoins();
            updateSearchAndFilterBlock();
        }

        public void loadCoins(List<CoinBase>? coins = null)
        {
            if (coins == null) { coins = CoinList.AllCoins.ToList(); }

            flowLayoutPanel1.Controls.Clear();

            bool isFirstControl = true;

            foreach (var coin in coins)
            {
                BaseCoinBox listCoin = new BaseCoinBox(currentUser, coin)
                {
                    Width = flowLayoutPanel1.Width - 20,
                    CoinTitle = coin.Name,
                    TypeCoin = coin.Type,
                    AvailableCountCoin = Convert.ToString(coin.AvailableCount),
                    YearCoin = Convert.ToString(coin.Year),
                    PriceCoin = Convert.ToString(coin.Price),
                    CoinImagePath = coin.ImagePath
                };

                if (isFirstControl)
                {
                    listCoin.Margin = new Padding(listCoin.Margin.Left, 0, listCoin.Margin.Right, listCoin.Margin.Bottom);
                    isFirstControl = false;
                }

                listCoin.EditCoinButtonClicked += CoinBox_EditButtonClicked;
                listCoin.DeleteCoinButtonClicked += CoinBox_DeleteButtonClicked;
                listCoin.CoinDetailsButtonClicked += CoinBox_DetailsButtonClicked;
                listCoin.CoinBasketButtonClicked += CoinBox_BasketButtonClicked;
                flowLayoutPanel1.Controls.Add(listCoin);
            }

            if (flowLayoutPanel1.Controls.Count == 0)
            {
                Label noCoinsLabel = new Label
                {
                    Text = "Монет не знайдено",
                    AutoSize = true,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                };
                flowLayoutPanel1.Controls.Add(noCoinsLabel);
            }
        }

        private void CoinBox_EditButtonClicked(object? sender, CoinBase coin)
        {
            EditCoinForm modalForm = new(coin);
            modalForm.ShowDialog();
            if (modalForm.isSaved)
            {
                CoinList.SaveCoinsToFile(coin);
                loadCoins();
                updateSearchAndFilterBlock();
            }
        }

        private void CoinBox_DeleteButtonClicked(object? sender, CoinBase coin)
        {
            DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити монету \"{coin.Name}\"?", "Видалення монети", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CoinList.RemoveCoin(coin);
                loadCoins();
                updateSearchAndFilterBlock();
            }
        }

        private void CoinBox_DetailsButtonClicked(object? sender, CoinBase coin)
        {
            ViewDetailsCoinForm modalForm = new(coin);
            modalForm.ShowDialog();
        }

        private void CoinBox_BasketButtonClicked(object? sender, CoinBase coin)
        {
            AddCoinToBasket addCoinToBasket = new(coin);
            addCoinToBasket.ShowDialog();
            //if (addCoinToBasket.isAdded)
            //{
            //    MessageBox.Show($"Монета \"{coin.Name}\" додана до кошика!", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void ordersAdminButtonClick(object? sender, EventArgs e)
        {
            OrdersForm ordersForm = new();
            ordersForm.ShowDialog();
        }

        private void ordersCustomerButtonClick(object? sender, EventArgs e)
        {
            OrdersForm ordersForm = new();
            ordersForm.ShowDialog();
        }

        private void basketCustomerButtonClick(object? sender, EventArgs e)
        {
            BasketForm basketForm = new();
            basketForm.ShowDialog();

            if (basketForm.isOrderCreated)
            {
                MessageBox.Show(
                    "Ваше замовлення успішно створене.\nДля перевірки його статусу перейдіть у розділ \"Замовлення\" на головній сторінці.",
                    "Замовлення оформлено",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                CoinList = new CoinsList();
                loadCoins();
            }
        }

        private void createNewCoinButton_Click(object sender, EventArgs e)
        {
            CreateCoinForm createCoinForm = new();
            createCoinForm.ShowDialog();
            if (createCoinForm.isCreated)
            {
                CoinList.AddCoin(createCoinForm.newCoin);
                CoinList.SaveCoinsToFile(createCoinForm.newCoin);
                loadCoins();
                updateSearchAndFilterBlock();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void updateSearchAndFilterBlock()
        {
            coinSeriesComboBox.SelectedIndex = -1;
            coinMaterialsCheckedListBox.ClearSelected();

            coinMaterialsCheckedListBox.Items.Clear();
            coinMaterialsCheckedListBox.Items.AddRange(CoinList.AllCoins.Select(c => c.Material).Distinct().ToArray());

            coinTypesCheckedListBox.Items.Clear();
            coinTypesCheckedListBox.Items.AddRange(CoinList.AllCoins.Select(c => c.Type).Distinct().ToArray());

            coinSeriesComboBox.Items.Clear();
            coinSeriesComboBox.Items.AddRange(CoinList.AllCoins.Select(c => c.Series).Distinct().ToArray());
        }

        private void applySearchButton_Click(object sender, EventArgs e)
        {
            string coinNameNextBox = coinNameTextBox.Text.Trim();
            string coinPriceFrom = coinPriceFromTextBox.Text.Trim();

            string coinPriceTo = coinPriceToTextBox.Text.Trim();
            string coinYearFrom = coinYearFromTextBox.Text.Trim();

            string coinYearTo = coinYearToTextBox.Text.Trim();
            List<string> coinMaterials = coinMaterialsCheckedListBox.CheckedItems.Cast<string>().ToList();
            List<string> coinTypes = coinTypesCheckedListBox.CheckedItems.Cast<string>().ToList();
            string? coinSeries = coinSeriesComboBox.SelectedItem?.ToString();

            string coinDiameterFrom = coinDiameterFromTextBox.Text.Trim();
            string coinDiameterTo = coinDiameterToTextBox.Text.Trim();

            List<CoinBase> filteredCoins = CoinList.AllCoins.ToList();

            if (!string.IsNullOrWhiteSpace(coinNameNextBox))
            {
                filteredCoins = CoinList.AllCoins
                .Where(c => c.Name.Contains(coinNameNextBox, StringComparison.OrdinalIgnoreCase)).ToList();
            }


            if (!string.IsNullOrWhiteSpace(coinPriceFrom) || !string.IsNullOrWhiteSpace(coinPriceTo))
            {
                string errorMsg = "";
                int? priceFrom = null;
                int? priceTo = null;

                string fromInput = coinPriceFrom;
                if (!string.IsNullOrEmpty(fromInput))
                {
                    if (!int.TryParse(fromInput, out int number) || number <= 0)
                    {
                        errorMsg = "Введіть ціле число більше 0.";
                        InvalidTextBox(coinPriceFromTextBox, errorMsg);
                        return;
                    }
                    priceFrom = number;
                    coinPriceFromTextBox.BackColor = SystemColors.Window;
                }
                else { coinPriceFromTextBox.BackColor = SystemColors.Window; }

                string toInput = coinPriceTo;
                if (!string.IsNullOrEmpty(toInput))
                {
                    if (!int.TryParse(toInput, out int number) || number <= 0)
                    {
                        errorMsg = "Введіть ціле число більше 0.";
                        InvalidTextBox(coinPriceToTextBox, errorMsg);
                        return;
                    }
                    priceTo = number;
                    coinPriceToTextBox.BackColor = SystemColors.Window;
                }
                else { coinPriceToTextBox.BackColor = SystemColors.Window; }

                if (priceFrom.HasValue && priceTo.HasValue && priceFrom > priceTo)
                {
                    errorMsg = "Ціна \"від\" не може бути більшою за ціну \"до\".";
                    MessageBox.Show(errorMsg, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (priceFrom.HasValue) { filteredCoins = filteredCoins.Where(c => c.Price >= priceFrom.Value).ToList(); }
                if (priceTo.HasValue) { filteredCoins = filteredCoins.Where(c => c.Price <= priceTo.Value).ToList(); }
            }


            if (!string.IsNullOrWhiteSpace(coinYearFrom) || !string.IsNullOrWhiteSpace(coinYearTo))
            {
                string errorMsg = "";
                int? yearFrom = null;
                int? yearTo = null;

                string fromInput = coinYearFrom;
                if (!string.IsNullOrEmpty(fromInput))
                {
                    if (!int.TryParse(fromInput, out int number) || number <= 0)
                    {
                        errorMsg = "Введіть ціле число більше 0.";
                        InvalidTextBox(coinYearFromTextBox, errorMsg);
                        return;
                    }
                    yearFrom = number;
                    coinYearFromTextBox.BackColor = SystemColors.Window;
                }
                else { coinYearFromTextBox.BackColor = SystemColors.Window; }

                string toInput = coinYearTo;
                if (!string.IsNullOrEmpty(toInput))
                {
                    if (!int.TryParse(toInput, out int number) || number <= 0)
                    {
                        errorMsg = "Введіть ціле число більше 0.";
                        InvalidTextBox(coinYearToTextBox, errorMsg);
                        return;
                    }
                    yearTo = number;
                    coinYearToTextBox.BackColor = SystemColors.Window;
                }
                else { coinYearToTextBox.BackColor = SystemColors.Window; }

                if (yearFrom.HasValue && yearTo.HasValue && yearFrom > yearTo)
                {
                    errorMsg = "Рік випуску \"від\" не може бути більшим за рік випуску \"до\".";
                    MessageBox.Show(errorMsg, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (yearFrom.HasValue) { filteredCoins = filteredCoins.Where(c => c.Year >= yearFrom.Value).ToList(); }
                if (yearTo.HasValue) { filteredCoins = filteredCoins.Where(c => c.Year <= yearTo.Value).ToList(); }

            }

            if (coinMaterials.Count > 0)
            {
                filteredCoins = filteredCoins.Where(c => coinMaterials.Contains(c.Material)).ToList();
            }

            if (coinTypes.Count > 0)
            {
                filteredCoins = filteredCoins.Where(c => coinTypes.Contains(c.Type)).ToList();
            }

            if (coinSeries != null)
            {
                filteredCoins = filteredCoins.Where(c => c.Series.Equals(coinSeries, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(coinDiameterFrom) || !string.IsNullOrWhiteSpace(coinDiameterTo))
            {
                string errorMsg = "";
                double? diameterFrom = null;
                double? diameterTo = null;

                string fromInput = coinDiameterFrom;
                if (!string.IsNullOrEmpty(fromInput))
                {
                    if (!double.TryParse(fromInput, out double number) || number <= 0)
                    {
                        errorMsg = "Введіть ціле число більше 0.";
                        InvalidTextBox(coinDiameterFromTextBox, errorMsg);
                        return;
                    }
                    diameterFrom = number;
                    coinDiameterFromTextBox.BackColor = SystemColors.Window;
                }
                else { coinDiameterFromTextBox.BackColor = SystemColors.Window; }

                string toInput = coinDiameterTo;
                if (!string.IsNullOrEmpty(toInput))
                {
                    if (!double.TryParse(toInput, out double number) || number <= 0)
                    {
                        errorMsg = "Введіть ціле число більше 0.";
                        InvalidTextBox(coinDiameterToTextBox, errorMsg);
                        return;
                    }
                    diameterTo = number;
                    coinDiameterToTextBox.BackColor = SystemColors.Window;
                }
                else { coinDiameterToTextBox.BackColor = SystemColors.Window; }

                if (diameterFrom.HasValue && diameterTo.HasValue && diameterFrom > diameterTo)
                {
                    errorMsg = "Діаметр \"від\" не може бути більшим за діаметр \"до\".";
                    MessageBox.Show(errorMsg, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (diameterFrom.HasValue) { filteredCoins = filteredCoins.Where(c => c.Diameter >= diameterFrom.Value).ToList(); }
                if (diameterTo.HasValue) { filteredCoins = filteredCoins.Where(c => c.Diameter <= diameterTo.Value).ToList(); }
            }

            loadCoins(filteredCoins);

            //if (!CoinList.Coins.Equals(filteredCoins))
            //{
            //    loadCoins(filteredCoins);
            //}
        }

        private void InvalidTextBox(TextBox curTextBox, string error = "")
        {
            curTextBox.BackColor = Color.LightPink;
            MessageBox.Show(error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені що хочете вийти?", "Вийти з акаунту", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserSession.Logout();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void userLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditAccountForm modalForm = new EditAccountForm(currentUser);
            modalForm.ShowDialog();
            if (modalForm.isEdited)
            {
                userLoginLinkLabel.Text = $"{currentUser.Name} {currentUser.Surname}".Trim();
            }
        }
    }
}
