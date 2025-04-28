using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
    class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();
        public void AddItem(int productId, int quantity)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                Items.Add(new ShoppingCartItem { ProductId = productId, Quantity = quantity });
            }
        }
        public void RemoveItem(int productId)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                Items.Remove(item);
            }
        }
        public void Clear()
        {
            Items.Clear();
        }
    }
}
