using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class TokenResponse : List<TokenResponse.TokenItem>
    {
        public class TokenItem
        {
            public string Name { get; set; }
            public string Symbol { get; set; }
            public string Denom { get; set; }
            public int Decimals { get; set; }
            public string Blockchain { get; set; }

            [JsonPropertyName("chain_id")]
            public int ChainId { get; set; }

            [JsonPropertyName("asset_id")]
            public string AssetId { get; set; }

            [JsonPropertyName("is_active")]
            public bool IsActive { get; set; }

            [JsonPropertyName("is_collateral")]
            public bool IsCollateral { get; set; }

            [JsonPropertyName("lock_proxy_hash")]
            public string LockProxyHash { get; set; }

            [JsonPropertyName("delegated_supply")]
            public string DelegatedSupply { get; set; }

            public string Originator { get; set; }
        }
    }
}
