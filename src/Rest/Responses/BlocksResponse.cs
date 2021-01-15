using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class BlocksResponse : List<BlocksResponse.BlockItem>
    {
        public class BlockItem
        {
            [JsonPropertyName("block_height")]
            public string BlockHeight { get; set; }

            public DateTimeOffset Time { get; set; }
            public string Count { get; set; }

            [JsonPropertyName("proposer_address")]
            public string ProposerAddress { get; set; }
        }
    }
}
