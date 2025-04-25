using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public class Coin
    {
        private static int _idCounter = 1;
        public readonly int Id = _idCounter++;
        public string Name { get; set; }
        public int Year { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
        public int AvailableCount { get; set; }
        public string Country { get; set; }

        public Image Image { get; set; }
        public string Description { get; set; }
        public int Denomination { get; set; }
        public double Diameter { get; set; }
        public string Series { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Year}) - {Material}";
        }
    }
}
