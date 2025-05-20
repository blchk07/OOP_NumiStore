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

namespace OOP_NumiStore
{
    public partial class OrderedCoinBox: UserControl
    {
        private string _coinImagePath;
        public OrderedCoinBox()
        {
            InitializeComponent();
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
                selectedCountLabel.Text = $"{value} шт.";
            }
        }

        [Category("Custom Props")]
        public string TotalPrice
        {
            set
            {
                resultLabel.Text = $"{value} грн.";
            }
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
    }
}
