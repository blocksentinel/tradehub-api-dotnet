using System.Collections.Generic;

namespace TradeHub.Rest.Responses
{
    public class BalanceResponse : Dictionary<string, BalanceResponse.BalanceItem>
    {
        public class BalanceItem
        {
            public string Available { get; set; }
            public string Order { get; set; }
            public string Position { get; set; }
            public string Denom { get; set; }
        }
    }
}
