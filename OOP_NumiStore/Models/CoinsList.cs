using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public class CoinsList
    {
        public List<Coin> Coins { get; private set; } = new List<Coin>();
        public void AddCoin(Coin coin)
        {
            Coins.Add(coin);
        }
        public void RemoveCoin(Coin coin)
        {
            Coins.Remove(coin);
        }
        public void ClearCoins()
        {
            Coins.Clear();
        }
    }
}
