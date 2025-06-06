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
    public partial class AddCoinToBasket : Form
    {
        private CoinBase currentCoin;
        private Customer currentCustomer = UserSession.currentUser as Customer;
        private UsersManager usersManager = new UsersManager();
        int selectedCount = 1;
        public AddCoinToBasket(CoinBase currentCoin)
        {
            InitializeComponent();
            this.currentCoin = currentCoin;
            selectedCountNumeric.TextChanged += selectedCountNumeric_TextChanged;

            InitializeLabels();
            InitializePicture();
        }

        private void InitializeLabels()
        {
            selectedCountNumeric.Maximum = currentCoin.AvailableCount;

            coinNameText.Text = currentCoin.Name;
            coinTypeLabel.Text = currentCoin.Type;
            avaiableCountLabel.Text = currentCoin.AvailableCount.ToString();
            oneCoinPriceLabel.Text = $"{currentCoin.Price} грн.";

            int count = (int)selectedCountNumeric.Value;
            decimal total = count * currentCoin.Price;
            resultLabel.Text = $"Загалом: {count} x {currentCoin.Price} = {total} грн.";
        }

        private void InitializePicture()
        {
            if (!string.IsNullOrEmpty(currentCoin.ImagePath) && File.Exists(currentCoin.ImagePath))
            {
                try
                {
                    coinPictureBox.Image = Image.FromFile(currentCoin.ImagePath);
                    coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch { coinPictureBox.Image = null; }
            }
            else coinPictureBox.Image = null;
        }

        public void selectedCountNumeric_TextChanged(object sender, EventArgs e)
        {
            resultLabel.Text = $"Загалом: {selectedCountNumeric.Value} x {currentCoin.Price} = " + (selectedCountNumeric.Value * currentCoin.Price).ToString() + " грн.";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            selectedCount = (int)selectedCountNumeric.Value;

            var currentBasketItem = currentCustomer.Basket.FirstOrDefault(c => c.CoinId == currentCoin.Id);
            int currentQuantity = currentBasketItem?.Quantity ?? 0;

            if (currentQuantity + selectedCount <= currentCoin.AvailableCount)
            {
                currentCustomer.AddBasketItem(new BasketItem { CoinId = currentCoin.Id, Quantity = selectedCount });
                usersManager.UpdateCustomers(currentCustomer);
                MessageBox.Show("Монета успішно додана до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Неможливо додати {selectedCount} шт. Ця монета доступна в кількості {currentCoin.AvailableCount - currentQuantity}.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
