using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class CandlesticksResponse : List<CandlesticksResponse.CandlestickItem>
    {
        public class CandlestickItem
        {
            public int Id { get; set; }
            public string Market { get; set; }
            public DateTimeOffset Time { get; set; }
            public int Resolution { get; set; }
            public decimal Open { get; set; }
            public decimal Close { get; set; }
            public decimal High { get; set; }
            public decimal Low { get; set; }
            public string Volume { get; set; }

            [JsonPropertyName("quote_volume")]
            public decimal QuoteVolume { get; set; }
        }
    }
}
