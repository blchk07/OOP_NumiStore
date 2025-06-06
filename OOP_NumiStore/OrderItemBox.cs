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
using OOP_NumiStore.Forms;

namespace OOP_NumiStore
{
    public partial class OrderItemBox : UserControl
    {
        public Order currentOrder { get; private set; }
        OrdersManager ordersManager = new OrdersManager();
        User currentUser = UserSession.currentUser;
        public OrderItemBox(Order order)
        {
            InitializeComponent();
            currentOrder = order;
            orderIdText.Text = $"№ {currentOrder.OrderId}";
            totalAmountLabel.Text = currentOrder.TotalAmount + " грн";
            datetimeLabel.Text = currentOrder.OrderDate.ToString();
            orderStatusLabel.Text = GetEnumDescription(currentOrder.Status);

            changeStatusButton.Visible = currentUser is Admin;
            if (currentUser is Admin admin) SetStatusButton();
        }

        private static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute)field?.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();
            return attribute?.Description ?? value.ToString();
        }

        private void SetStatusButton()
        {
            switch (currentOrder.Status)
            {
                case OrderStatus.InProgress:
                    changeStatusButton.Text = "Відправити";
                    break;
                case OrderStatus.Shipped:
                    changeStatusButton.Text = "Виконати";
                    break;
                case OrderStatus.Completed:
                    changeStatusButton.Text = "Виконано";
                    changeStatusButton.Enabled = false;
                    break;
            }
        }

        private void changeStatusButton_Click(object sender, EventArgs e)
        {
            switch (currentOrder.Status)
            {
                case OrderStatus.InProgress:
                    ordersManager.ChangeStatus(currentOrder.OrderId, OrderStatus.Shipped);
                    currentOrder.Status = OrderStatus.Shipped;
                    break;
                case OrderStatus.Shipped:
                    ordersManager.ChangeStatus(currentOrder.OrderId, OrderStatus.Completed);
                    currentOrder.Status = OrderStatus.Completed;
                    break;
                case OrderStatus.Completed:
                    break;
            }
            orderStatusLabel.Text = GetEnumDescription(currentOrder.Status);
            SetStatusButton();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            OrderDetailsForm orderDetailsForm = new OrderDetailsForm(currentOrder);
            orderDetailsForm.ShowDialog();
        }
    }
}
