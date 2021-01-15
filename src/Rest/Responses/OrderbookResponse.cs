using System.Collections.Generic;

namespace TradeHubSharp.Rest.Responses
{
    public class OrderbookResponse
    {
        public IEnumerable<OrderItem> Asks { get; set; }
        public IEnumerable<OrderItem> Bids { get; set; }

        public class OrderItem
        {
            public string Price { get; set; }
            public string Quantity { get; set; }
        }
    }
}
