using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OOP_NumiStore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_NumiStore.Forms
{
    public partial class MainAdminForm : Form
    {
        public CoinsList CoinList { get; private set; } = new CoinsList();
        User currentUser { get; set; }

        public MainAdminForm()
        {
            InitializeComponent();
            currentUser = UserSession.currentUser;

            //Coin coin1 = new Coin
            //{
            //    Name = "Києво-Печерська лавра",
            //    Year = 1996,
            //    Material = "золото",
            //    Price = 500m,
            //    AvailableCount = 450,
            //    Country = "Україна",
            //    Description = "Присвячена видатній архітектурно-історичній пам`ятці...",
            //    Denomination = 200,
            //    Diameter = 25.0,
            //    Series = "Духовні скарби України",
            //};
            //Coin coin2 = new Coin
            //{
            //    Name = "Київська Русь",
            //    Year = 1997,
            //    Material = "срібло",
            //    Price = 600m,
            //    AvailableCount = 300,
            //    Country = "Україна",
            //    Description = "Присвячена історії Київської Русі...",
            //    Denomination = 100,
            //    Diameter = 30.0,
            //    Series = "Історія України",
            //};
            //Coin coin3 = new Coin
            //{
            //    Name = "Золотий тризуб",
            //    Year = 1998,
            //    Material = "золото",
            //    Price = 100000.00m,
            //    AvailableCount = 200,
            //    Country = "Україна",
            //    Description = "Присвячена тризубу як символу...",
            //    Denomination = 500,
            //    Diameter = 40.0,
            //    Series = "Національні символи України",
            //};
            //Coin coin4 = new Coin
            //{
            //    Name = "Київська Космічна ера",
            //    Year = 1999,
            //    Material = "срібло",
            //    Price = 20000.00m,
            //    AvailableCount = 100,
            //    Country = "Україна",
            //    Description = "Присвячена досягненням в космонавтиці...",
            //    Denomination = 50,
            //    Diameter = 35.0,
            //    Series = "Космос України",
            //};
            //CoinList.AddCoin(coin1);
            //CoinList.AddCoin(coin2);
            //CoinList.AddCoin(coin3);
            //CoinList.AddCoin(coin4);

            loadCoins();
            updateSearchAndFilterBlock();
        }

        public void loadCoins(List<Coin>? coins = null)
        {
            if (coins == null) { coins = CoinList.Coins; }

            flowLayoutPanel1.Controls.Clear();

            foreach (Coin coin in coins)
            {
                BaseCoinBox adminListCoin = new BaseCoinBox(currentUser)
                {
                    Coin = coin,
                    Width = flowLayoutPanel1.Width - 20,
                    CoinTitle = coin.Name,
                    YearCoin = Convert.ToString(coin.Year),
                    CountryCoin = coin.Country,
                    PriceCoin = Convert.ToString(coin.Price),
                    CoinImage = coin.Image
                };
                adminListCoin.EditCoinButtonClicked += CoinBox_EditButtonClicked;
                adminListCoin.DeleteCoinButtonClicked += CoinBox_DeleteButtonClicked;
                flowLayoutPanel1.Controls.Add(adminListCoin);
            }
        }

        private void CoinBox_EditButtonClicked(object? sender, Coin coin)
        {
            EditCoinForm modalForm = new(coin);
            modalForm.ShowDialog();
            if (modalForm.isSaved)
            {
                CoinList.SaveCoinsToFile();
                loadCoins();
                updateSearchAndFilterBlock();
            }
        }

        private void CoinBox_DeleteButtonClicked(object? sender, Coin coin)
        {
            DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити монету \"{coin.Name}\"?", "Видалення монети", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                CoinList.RemoveCoin(coin);
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
            coinCountryComboBox.SelectedIndex = -1;
            coinSeriesComboBox.SelectedIndex = -1;
            coinMaterialsCheckedListBox.ClearSelected();

            coinCountryComboBox.Items.Clear();
            coinCountryComboBox.Items.AddRange(CoinList.Coins.Select(c => c.Country).Distinct().ToArray());

            coinMaterialsCheckedListBox.Items.Clear();
            coinMaterialsCheckedListBox.Items.AddRange(CoinList.Coins.Select(c => c.Material).Distinct().ToArray());

            coinSeriesComboBox.Items.Clear();
            coinSeriesComboBox.Items.AddRange(CoinList.Coins.Select(c => c.Series).Distinct().ToArray());
        }

        private void applySearchButton_Click(object sender, EventArgs e)
        {
            string coinNameNextBox = coinNameTextBox.Text.Trim();
            string coinPriceFrom = coinPriceFromTextBox.Text.Trim();

            string coinPriceTo = coinPriceToTextBox.Text.Trim();
            string coinYearFrom = coinYearFromTextBox.Text.Trim();

            string coinYearTo = coinYearToTextBox.Text.Trim();
            string? coinCountry = coinCountryComboBox.SelectedItem?.ToString();
            List<string> coinMaterials = coinMaterialsCheckedListBox.CheckedItems.Cast<string>().ToList();
            string? coinSeries = coinSeriesComboBox.SelectedItem?.ToString();

            string coinDiameterFrom = coinDiameterFromTextBox.Text.Trim();
            string coinDiameterTo = coinDiameterToTextBox.Text.Trim();

            List<Coin> filteredCoins = CoinList.Coins;

            if (!string.IsNullOrWhiteSpace(coinNameNextBox))
            {
                filteredCoins = CoinList.Coins
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

            if (coinCountry != null)
            {
                filteredCoins = filteredCoins.Where(c => c.Country.Equals(coinCountry, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (coinMaterials.Count > 0)
            {
                filteredCoins = filteredCoins.Where(c => coinMaterials.Contains(c.Material)).ToList();
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
        }

        private void InvalidTextBox(System.Windows.Forms.TextBox curTextBox, string error = "")
        {
            curTextBox.BackColor = Color.LightPink;
            MessageBox.Show(error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
