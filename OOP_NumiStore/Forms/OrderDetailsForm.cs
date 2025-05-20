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
    public partial class OrderDetailsForm: Form
    {
        private Order currentOrder;
        public OrderDetailsForm(Order currentOrder)
        {
            InitializeComponent();
            this.currentOrder = currentOrder;
            Text = $"Деталі замовлення {currentOrder.OrderId}";
            loadOrderDetails();
        }

        private void loadOrderDetails()
        {
            if (currentOrder != null)
            {
                foreach (var item in currentOrder.Items)
                {
                    OrderedCoinBox orderedCoinBox = new OrderedCoinBox
                    {
                        CoinTitle = item.Name,
                        TypeCoin = item.Type,
                        SelectedCountCoin = item.Quantity.ToString(),
                        CoinImagePath = item.ImagePath,
                        TotalPrice = (item.Price * item.Quantity).ToString(),
                    };
                    flowLayoutPanel1.Controls.Add(orderedCoinBox);
                }
            }
        }
    }
}
