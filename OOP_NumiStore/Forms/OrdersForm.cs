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

            List<Order> orders = currentUser is Customer ? ordersManager.LoadOrders(currentUser.Login) : ordersManager.LoadOrders();
            bool isFirstControl = true;
            orders.Reverse();

            foreach (var order in orders)
            {
                OrderItemBox orderItemBox = new OrderItemBox(order);

                if (isFirstControl)
                {
                    orderItemBox.Margin = new Padding(orderItemBox.Margin.Left, 0, orderItemBox.Margin.Right, orderItemBox.Margin.Bottom);
                    isFirstControl = false;
                }

                flowLayoutPanel1.Controls.Add(orderItemBox);
            }
        }
    }
}
