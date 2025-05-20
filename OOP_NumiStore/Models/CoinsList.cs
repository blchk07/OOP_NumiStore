using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace OOP_NumiStore.Models
{
    public class CoinsList
    {
        private const string regularCoinFilePath = @"json\regular_coins.json";
        private const string collectibleCoinFilePath = @"json\collectible_coins.json";

        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
        };

        public List<RegularCoin> RegularCoins { get; private set; } = new();
        public List<CollectibleCoin> CollectibleCoins { get; private set; } = new();
        public IEnumerable<CoinBase> AllCoins => RegularCoins.Cast<CoinBase>().Concat(CollectibleCoins);

        public CoinsList()
        {
            LoadCoinsFromFile();
        }

        public void AddCoin(CoinBase coin)
        {
            if (coin is RegularCoin regular)
            {
                RegularCoins.Add(regular);
                SaveRegularCoins();
            }
            else if (coin is CollectibleCoin collectible)
            {
                CollectibleCoins.Add(collectible);
                SaveCollectibleCoins();
            }
        }

        public void EditCoin(CoinBase coin)
        {
            if (coin is RegularCoin regular)
            {
                var existing = RegularCoins.FirstOrDefault(c => c.Id == regular.Id);
                if (existing != null)
                {
                    int index = RegularCoins.IndexOf(existing);
                    RegularCoins[index] = regular;
                    SaveRegularCoins();
                }
            }
            else if (coin is CollectibleCoin collectible)
            {
                var existing = CollectibleCoins.FirstOrDefault(c => c.Id == collectible.Id);
                if (existing != null)
                {
                    int index = CollectibleCoins.IndexOf(existing);
                    CollectibleCoins[index] = collectible;
                    SaveCollectibleCoins();
                }
            }
        }

        public void RemoveCoin(CoinBase coin)
        {
            if (coin is RegularCoin regular)
            {
                RegularCoins.Remove(regular);
                SaveRegularCoins();
            }
            else if (coin is CollectibleCoin collectible)
            {
                CollectibleCoins.Remove(collectible);
                SaveCollectibleCoins();
            }
        }

        public void ClearCoins()
        {
            RegularCoins.Clear();
            CollectibleCoins.Clear();
            SaveRegularCoins();
            SaveCollectibleCoins();
        }

        private void SaveRegularCoins()
        {
            try
            {
                string json = JsonSerializer.Serialize(RegularCoins, _jsonOptions);
                File.WriteAllText(regularCoinFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні регулярних монет: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCollectibleCoins()
        {
            try
            {
                string json = JsonSerializer.Serialize(CollectibleCoins, _jsonOptions);
                File.WriteAllText(collectibleCoinFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні колекційних монет: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCoinsFromFile()
        {
            RegularCoins = LoadFromFile<RegularCoin>(regularCoinFilePath);
            CollectibleCoins = LoadFromFile<CollectibleCoin>(collectibleCoinFilePath);
        }

        private List<T> LoadFromFile<T>(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string data = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(data))
                    {
                        return JsonSerializer.Deserialize<List<T>>(data, _jsonOptions) ?? new List<T>();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні з файлу {filePath}: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new List<T>();
        }
        public void SaveCoinsToFile(CoinBase currentCoin)
        {
            if (currentCoin is RegularCoin) SaveRegularCoins();
            else if (currentCoin is CollectibleCoin) SaveCollectibleCoins();
        }
    }
}
