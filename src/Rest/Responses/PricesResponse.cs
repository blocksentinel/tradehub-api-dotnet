using System;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class PricesResponse
    {
        public string Last { get; set; }
        public string Index { get; set; }
        public string Fair { get; set; }
        public string Mark { get; set; }

        [JsonPropertyName("mark_avg")]
        public string MarkAvg { get; set; }

        public string Settlement { get; set; }

        [JsonPropertyName("fair_index_delta_avg")]
        public string FairIndexDeltaAvg { get; set; }

        public string Market { get; set; }

        [JsonPropertyName("marking_strategy")]
        public string MarkingStrategy { get; set; }

        [JsonPropertyName("index_updated_at")]
        public DateTimeOffset IndexUpdatedAt { get; set; }

        [JsonPropertyName("last_updated_at")]
        public DateTimeOffset LastUpdatedAt { get; set; }

        [JsonPropertyName("block_height")]
        public int BlockHeight { get; set; }
    }
}
