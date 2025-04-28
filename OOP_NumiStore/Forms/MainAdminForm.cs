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
        CoinsList CoinList = new CoinsList();
        User currentUser { get; set; }

        public MainAdminForm()
        {
            InitializeComponent();
            currentUser = UserSession.currentUser;

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
            CoinList.AddCoin(coin1);
            CoinList.AddCoin(coin2);
            CoinList.AddCoin(coin3);
            CoinList.AddCoin(coin4);

            comboBox3.Items.AddRange(CoinSettings.coinCountries.ToArray());
            comboBox1.Items.AddRange(CoinSettings.coinMaterials.ToArray());

            loadCoins();
        }

        public void loadCoins()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Coin coin in CoinList.Coins)
            {
                BaseCoinBox adminListCoin = new BaseCoinBox(currentUser)
                {
                    Coin = coin,
                    Width = flowLayoutPanel1.Width - 20,
                    CoinTitle = coin.Name,
                    YearCoin = Convert.ToString(coin.Year),
                    CountryCoin = coin.Country,
                    PriceCoin = Convert.ToString(coin.Price),
                    CoinImage = coin.Image,
                    MainAdminForm = this,
                };
                //
                flowLayoutPanel1.Controls.Add(adminListCoin);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
