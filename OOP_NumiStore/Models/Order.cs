using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public class Order
    {
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public string CustomerLogin { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderedCoin> Items { get; set; } = new();
        public decimal TotalAmount => Items.Sum(i => i.Total);
        public OrderStatus Status { get; set; } = OrderStatus.InProgress;
    }

    public enum OrderStatus
    {
        [Description("В процесі ⏳")]
        InProgress,
        [Description("Відправлено 🚚")]
        Shipped,
        [Description("Виконано ✅")]
        Completed
    }
}
