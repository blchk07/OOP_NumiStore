using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOP_NumiStore.Models
{
    public class CoinsList
    {
        public List<Coin> Coins { get; private set; } = new List<Coin>();
        private const string coinFilePath = @"json\coins.json";
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All)
        };
        public CoinsList()
        {
            LoadCoinsFromFile();
        }
        public void AddCoin(Coin coin)
        {
            Coins.Add(coin);
            SaveCoinsToFile();
        }
        public void RemoveCoin(Coin coin)
        {
            Coins.Remove(coin);
            SaveCoinsToFile();
        }
        public void ClearCoins()
        {
            Coins.Clear();
            SaveCoinsToFile();
        }

        public void SaveCoinsToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(Coins, _jsonOptions);
                File.WriteAllText(coinFilePath, json, System.Text.Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні монет у файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCoinsFromFile()
        {
            if (File.Exists(coinFilePath))
            {
                string data = File.ReadAllText(coinFilePath);
                if (data.Trim() != "")
                {
                    Coins = JsonSerializer.Deserialize<List<Coin>>(data, _jsonOptions) ?? new List<Coin>();
                    return;
                }
            }
            Coins = new List<Coin>();
        }
    }
}
