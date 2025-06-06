using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_NumiStore.Models
{
    public partial class OrdersForm: Form
    {
        User currentUser { get; set; } = UserSession.currentUser;
        OrdersManager ordersManager { get; set; } = new OrdersManager();
        public OrdersForm()
        {
            InitializeComponent();
            var orders = LoadOrdersForUser();
            InitializeOrdersUI(orders);
        }
        private List<Order> LoadOrdersForUser()
        {
            if (currentUser is Customer) return ordersManager.LoadOrders(currentUser.Login);
            else return ordersManager.LoadOrders();
        }
        private void InitializeOrdersUI(List<Order> orders)
        {
            if (orders == null || orders.Count == 0)
            {
                ShowNoOrdersLabel();
                return;
            }

            orders.Reverse();
            bool isFirstControl = true;

            foreach (var order in orders)
            {
                var orderItemBox = new OrderItemBox(order);

                if (isFirstControl)
                {
                    orderItemBox.Margin = new Padding(
                        orderItemBox.Margin.Left, 0,
                        orderItemBox.Margin.Right, orderItemBox.Margin.Bottom
                    );
                    isFirstControl = false;
                }

                flowLayoutPanel1.Controls.Add(orderItemBox);
            }
        }
        private void ShowNoOrdersLabel()
        {
            var noItemsLabel = new Label
            {
                Text = "Замовлень немає",
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                Margin = new Padding(220, 150, 0, 0)
            };

            flowLayoutPanel1.Controls.Add(noItemsLabel);
        }
    }
}
