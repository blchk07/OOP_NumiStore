using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public abstract class CoinBase
    {
        public abstract string Type { get; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
        public int AvailableCount { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public double Diameter { get; set; }
        public string Series { get; set; }

        public override string ToString() { return $"{Name} ({Year}) - {Material}"; }
    }
    public class RegularCoin : CoinBase
    {
        public override string Type { get; } = "Оборотна";
        public int Denomination { get; set; }
    }
    public class CollectibleCoin : CoinBase
    {
        public override string Type { get; } = "Сувенірна";

        public override string ToString() { return $"{Name} ({Year}) - {Material} (сувенірна)"; }
    }

    public class OrderedCoin
    {
        public int CoinId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Price * Quantity;
    }

    public static class CoinSettings
    {
        public static List<string> coinMaterials = new List<string>
        {
            "золото",
            "срібло",
            "мідь",
            "бронза",
            "латунь",
            "нікель",
            "алюміній",
            "цинк",
            "сталь",
            "біметал",
            "платина",
            "паладій",
            "титан",
            "нейзильбер",
            "мельхіор",
            "електрум",
            "олово",
            "свинець",
            "кераміка",
            "полімер"
        };
        public static List<string> coinCountries = new List<string>
        {
            "Україна",
            "Польща",
            "Німеччина",
            "Франція",
            "Велика Британія",
            "Сполучені Штати Америки",
            "Канада",
            "Австралія",
            "Китай",
            "Японія",
            "Італія",
            "Іспанія",
            "Бразилія",
            "Мексика",
            "Австрія",
            "Швейцарія",
            "Нідерланди",
            "Бельгія",
            "Швеція",
            "Норвегія",
            "Фінляндія",
            "Греція",
            "Туреччина",
            "Індія",
            "Південна Африка",
            "Нова Зеландія",
            "Португалія",
            "Угорщина",
            "Чехія"
        };
    }
}
