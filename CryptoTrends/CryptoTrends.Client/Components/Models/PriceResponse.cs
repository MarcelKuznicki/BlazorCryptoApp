using Newtonsoft.Json;

namespace CryptoTrends.Client.Components.Models
{
    public class CryptoMarket
    {
        public string Id { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        [JsonProperty("current_price")] public decimal CurrentPrice { get; set; }
        [JsonProperty("market_cap")] public decimal MarketCap { get; set; }
        [JsonProperty("price_change_percentage_24h")] public decimal? PriceChange24h { get; set; }
    }
}
