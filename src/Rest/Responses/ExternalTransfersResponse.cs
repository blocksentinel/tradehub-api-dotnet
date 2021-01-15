using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHub.Rest.Responses
{
    public class ExternalTransfersResponse : List<ExternalTransfersResponse.ExternalTransferItem>
    {
        public class ExternalTransferItem
        {
            public string Address { get; set; }
            public string Amount { get; set; }

            [JsonPropertyName("block_height")]
            public int BlockHeight { get; set; }

            public string Blockchain { get; set; }

            [JsonPropertyName("contract_hash")]
            public string ContractHash { get; set; }

            public string Denom { get; set; }

            [JsonPropertyName("fee_address")]
            public string FeeAddress { get; set; }

            [JsonPropertyName("fee_amount")]
            public string FeeAmount { get; set; }

            public string Id { get; set; }
            public string Status { get; set; }
            public string Symbol { get; set; }
            public int Timestamp { get; set; }

            [JsonPropertyName("token_name")]
            public string TokenName { get; set; }

            [JsonPropertyName("transaction_hash")]
            public string TransactionHash { get; set; }

            [JsonPropertyName("transfer_type")]
            public string TransferType { get; set; }
        }
    }
}
