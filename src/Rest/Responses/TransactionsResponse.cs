using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class TransactionsResponse : List<TransactionsResponse.TransactionItem>
    {
        public class TransactionItem
        {
            public string Id { get; set; }
            public string Hash { get; set; }
            public string Address { get; set; }
            public string Username { get; set; }

            [JsonPropertyName("msg_type")]
            public string MsgType { get; set; }

            public string Msg { get; set; }
            public string Code { get; set; }

            [JsonPropertyName("gas_used")]
            public string GasUsed { get; set; }

            [JsonPropertyName("gas_limit")]
            public string GasLimit { get; set; }

            public string Memo { get; set; }
            public string Height { get; set; }

            [JsonPropertyName("block_time")]
            public DateTimeOffset BlockTime { get; set; }
        }
    }
}
