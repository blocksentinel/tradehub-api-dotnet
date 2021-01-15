using Refit;

namespace TradeHub.Rest.Requests
{
    public class CreateOrderRequest
    {
        public string Market { get; set; }
        public string Side { get; set; }
        public string Quantity { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }

        [AliasAs("stop_price")]
        public string StopPrice { get; set; }

        [AliasAs("time_in_force")]
        public string TimeInForce { get; set; }

        [AliasAs("trigger_type")]
        public string TriggerType { get; set; }

        [AliasAs("is_reduce_only")]
        public bool IsReduceOnly { get; set; }

        [AliasAs("is_post_only")]
        public bool IsPostOnly { get; set; }

        public string Originator { get; set; }
    }
}
