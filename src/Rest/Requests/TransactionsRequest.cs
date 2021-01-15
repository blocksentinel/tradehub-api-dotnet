using Refit;

namespace TradeHub.Rest.Requests
{
    public class TransactionsRequest
    {
        [AliasAs("message_type")]
        public string MessageType { get; set; }

        public string Height { get; set; }

        [AliasAs("before_id")]
        public string BeforeId { get; set; }

        [AliasAs("after_id")]
        public string AfterId { get; set; }

        [AliasAs("start_block")]
        public string StartBlock { get; set; }

        [AliasAs("end_block")]
        public string EndBlock { get; set; }

        [AliasAs("order_by")]
        public string OrderBy { get; set; }

        public string Limit { get; set; }
    }
}
