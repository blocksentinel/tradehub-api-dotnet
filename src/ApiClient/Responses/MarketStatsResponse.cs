using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class MarketStatsResponse : List<MarketStatsResponse.MarketStatsItem>
    {
        public class MarketStatsItem
        {
            [JsonPropertyName("day_high")]
            public string day_high { get; set; }

            [JsonPropertyName("day_low")]
            public string day_low { get; set; }

            [JsonPropertyName("day_open")]
            public string day_open { get; set; }

            [JsonPropertyName("day_close")]
            public string day_close { get; set; }

            [JsonPropertyName("day_volume")]
            public string day_volume { get; set; }

            [JsonPropertyName("day_quote_volume")]
            public string day_quote_volume { get; set; }

            [JsonPropertyName("index_price")]
            public string index_price { get; set; }

            [JsonPropertyName("mark_price")]
            public string mark_price { get; set; }

            [JsonPropertyName("last_price")]
            public string last_price { get; set; }

            [JsonPropertyName("market_type")]
            public string market_type { get; set; }

            [JsonPropertyName("open_interest")]
            public string open_interest { get; set; }
        }
    }
}
