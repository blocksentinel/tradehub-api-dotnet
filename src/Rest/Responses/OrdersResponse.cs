using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class OrdersResponse : List<OrdersResponse.OrderItem>
    {
        public class OrderItem
        {
            [JsonPropertyName("order_id")]
            public string OrderId { get; set; }

            [JsonPropertyName("block_height")]
            public int BlockHeight { get; set; }

            [JsonPropertyName("triggered_block_height")]
            public int TriggeredBlockHeight { get; set; }

            public string Address { get; set; }
            public string Market { get; set; }
            public string Side { get; set; }
            public string Price { get; set; }
            public string Quantity { get; set; }
            public string Available { get; set; }
            public string Filled { get; set; }

            [JsonPropertyName("order_status")]
            public string OrderStatus { get; set; }

            [JsonPropertyName("order_type")]
            public string OrderType { get; set; }

            public string Initiator { get; set; }

            [JsonPropertyName("time_in_force")]
            public string TimeInForce { get; set; }

            [JsonPropertyName("stop_price")]
            public string StopPrice { get; set; }

            [JsonPropertyName("trigger_type")]
            public string TriggerType { get; set; }

            [JsonPropertyName("allocated_margin_denom")]
            public string AllocatedMarginDenom { get; set; }

            [JsonPropertyName("allocated_margin_amount")]
            public string AllocatedMarginAmount { get; set; }

            [JsonPropertyName("is_liquidation")]
            public bool IsLiquidation { get; set; }

            [JsonPropertyName("is_post_only")]
            public bool IsPostOnly { get; set; }

            [JsonPropertyName("is_reduce_only")]
            public bool IsReduceOnly { get; set; }

            public string Type { get; set; }

            [JsonPropertyName("block_created_at")]
            public DateTimeOffset BlockCreatedAt { get; set; }

            public string Username { get; set; }
            public string Id { get; set; }
        }
    }
}
