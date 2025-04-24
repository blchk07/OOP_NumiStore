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

namespace OOP_NumiStore.Forms
{
    public partial class MainAdminForm : Form
    {
        CoinCollection coinCollection = new CoinCollection();
        public MainAdminForm()
        {
            InitializeComponent();

            // Example coins
            Coin coin1 = new Coin
            {
                Name = "Києво-Печерська лавра",
                Year = 1996,
                Material = "золото",
                Price = 500m,
                AvailableCount = 450,
                Country = "Україна",
                Description = "Присвячена видатній архітектурно-історичній пам`ятці...",
                Denomination = 200,
                Diameter = 25.0,
                Series = "Духовні скарби України",
            };
            Coin coin2 = new Coin
            {
                Name = "Київська Русь",
                Year = 1997,
                Material = "срібло",
                Price = 600m,
                AvailableCount = 300,
                Country = "Україна",
                Description = "Присвячена історії Київської Русі...",
                Denomination = 100,
                Diameter = 30.0,
                Series = "Історія України",
            };
            Coin coin3 = new Coin
            {
                Name = "Золотий тризуб",
                Year = 1998,
                Material = "золото",
                Price = 100000.00m,
                AvailableCount = 200,
                Country = "Україна",
                Description = "Присвячена тризубу як символу...",
                Denomination = 500,
                Diameter = 40.0,
                Series = "Національні символи України",
            };
            Coin coin4 = new Coin
            {
                Name = "Космічна ера",
                Year = 1999,
                Material = "срібло",
                Price = 20000.00m,
                AvailableCount = 100,
                Country = "Україна",
                Description = "Присвячена досягненням в космонавтиці...",
                Denomination = 50,
                Diameter = 35.0,
                Series = "Космос України",
            };
            coinCollection.AddCoin(coin1);
            coinCollection.AddCoin(coin2);
            coinCollection.AddCoin(coin3);
            coinCollection.AddCoin(coin4);
            loadCoins(flowLayoutPanel1, coinCollection);
        }

        private void loadCoins(FlowLayoutPanel currentFlowLayoutPanel, CoinCollection currentCoinCollection)
        {
            currentFlowLayoutPanel.Controls.Clear();
            // Load coins into the flow layout panel
            foreach (Coin coin in currentCoinCollection.Coins)
            {
                BaseCoinBox adminListCoin = new BaseCoinBox
                {
                    Coin = coin,
                    Width = currentFlowLayoutPanel.Width - 20,
                    CoinTitle = coin.Name,
                    PriceCoin = $"Ціна: {coin.Price} грн.",
                    CoinImage = coin.Image,
                };
                // Testing
                adminListCoin.CoinDetailButton.Visible = coin.Price > 1000;
                //
                currentFlowLayoutPanel.Controls.Add(adminListCoin);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
