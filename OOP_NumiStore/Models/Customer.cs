using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    class Customer : User
    {
        public List<BasketItem> Basket { get; set; } = new();
        public bool AddBasketItem(BasketItem item)
        {
            var existingItem = Basket.FirstOrDefault(b => b.CoinId == item.CoinId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Basket.Add(item);
            }
            return true;
        }
        public bool EditBasketItem(BasketItem item)
        {
            var existingItem = Basket.FirstOrDefault(b => b.CoinId == item.CoinId);
            if (existingItem != null)
            {
                existingItem.Quantity = item.Quantity;
                return true;
            }
            return false;
        }

        public bool DeleteBasketItem(BasketItem item)
        {
            return Basket.Remove(item);
        }

        public bool ClearBasket()
        {
            Basket.Clear();
            return true;
        }
    }
}
