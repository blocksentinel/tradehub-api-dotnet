using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class AccountResponse
    {
        public string Height { get; set; }
        public ResultItem Result { get; set; }

        public class ResultItem
        {
            public string Type { get; set; }
            public ValueItem Value { get; set; }
        }

        public class ValueItem
        {
            public string Address { get; set; }
            public IEnumerable<CoinItem> Coins { get; set; }

            [JsonPropertyName("public_key")]
            public PublicKeyItem PublicKey { get; set; }

            [JsonPropertyName("account_number")]
            public string AccountNumber { get; set; }

            public string Sequence { get; set; }
        }

        public class PublicKeyItem
        {
            public string Type { get; set; }
            public string Value { get; set; }
        }

        public class CoinItem
        {
            public string Denom { get; set; }
            public string Amount { get; set; }
        }
    }
}
