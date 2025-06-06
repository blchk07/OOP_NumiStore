﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_NumiStore.Models;

namespace OOP_NumiStore
{
    public partial class BasketCoinBox : UserControl
    {
        public event EventHandler<BasketItem> DeleteBasketItem;
        public event EventHandler<BasketItem> ChangeCount;
        private string _coinImagePath;
        public CoinBase CoinBase { get; set; }
        public BasketItem BasketItem { get; set; }
        public BasketCoinBox(CoinBase thisCoin)
        {
            InitializeComponent();
            selectedCountNumeric.TextChanged += selectedCountNumeric_TextChanged;
            CoinBase = thisCoin;
            selectedCountNumeric.Maximum = CoinBase.AvailableCount;
        }

        [Category("Custom Props")]
        public string CoinTitle
        {
            get { return coinNameText.Text; }
            set { coinNameText.Text = value; }
        }

        [Category("Custom Props")]
        public string TypeCoin
        {
            set { coinTypeLabel.Text = $"{value}"; }
        }

        [Category("Custom Props")]
        public string SelectedCountCoin
        {
            set
            {
                decimal.TryParse(value, out decimal result);
                selectedCountNumeric.Value = result > selectedCountNumeric.Maximum ? selectedCountNumeric.Maximum : result;
            }
        }

        [Category("Custom Props")]
        public string TotalPrice
        {
            set { resultLabel.Text = $"{value} грн."; }
        }

        [Category("Custom Props")]
        public string CoinImagePath
        {
            set
            {
                _coinImagePath = value;

                if (!string.IsNullOrEmpty(_coinImagePath) && File.Exists(_coinImagePath))
                {
                    try
                    {
                        coinPictureBox.Image = Image.FromFile(_coinImagePath);
                        coinPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        coinPictureBox.Image = null;
                    }
                }
                else
                {
                    coinPictureBox.Image = null;
                }
            }
        }

        private void selectedCountNumeric_TextChanged(object sender, EventArgs e)
        {
            decimal totalPrice = CoinBase.Price * selectedCountNumeric.Value;
            resultLabel.Text = $"{totalPrice} грн.";
            BasketItem.Quantity = (int)selectedCountNumeric.Value;
            ChangeCount?.Invoke(this, BasketItem);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteBasketItem?.Invoke(this, BasketItem);
        }
    }
}
