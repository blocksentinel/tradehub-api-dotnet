using System;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class ProfileResponse
    {
        public string Address { get; set; }

        [JsonPropertyName("last_seen_block")]
        public string LastSeenBlock { get; set; }

        [JsonPropertyName("last_seen_time")]
        public DateTimeOffset LastSeenTime { get; set; }

        public string Twitter { get; set; }
        public string Username { get; set; }
    }
}
