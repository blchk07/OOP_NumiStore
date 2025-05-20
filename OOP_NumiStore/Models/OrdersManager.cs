using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_NumiStore.Models
{
    class OrdersManager
    {
        List<Order> orders;
        private readonly string ordersFilePath = @"json\orders.json";

        public OrdersManager()
        {
            LoadOrders();
        }

        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            Converters = { new JsonStringEnumConverter() }
        };

        public void AddOrder(Order order)
        {
            orders.Add(order);
            SaveOrders();
        }

        public void RemoveOrder(Guid orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                orders.Remove(order);
                SaveOrders();
            }
        }

        public void ChangeStatus(Guid orderId, OrderStatus status)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                order.Status = status;
                SaveOrders();
            }
        }

        public void SaveOrders()
        {
            try
            {
                string data = JsonSerializer.Serialize(orders, _jsonOptions);
                File.WriteAllText(ordersFilePath, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час збережння у файл. {ordersFilePath}:\n{ex.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Order> LoadOrders(string? customerLogin = null)
        {
            if (File.Exists(ordersFilePath))
            {
                string json = File.ReadAllText(ordersFilePath);
                if (string.IsNullOrWhiteSpace(json))
                {
                    orders = new List<Order>();
                }
                else
                {
                    orders = JsonSerializer.Deserialize<List<Order>>(json, _jsonOptions) ?? new List<Order>();
                }
                return customerLogin != null ? orders.Where(o => o.CustomerLogin == customerLogin).ToList() : orders;
            }
            orders = new List<Order>();
            return new List<Order>();
        }
    }
}
