using System.Collections.Generic;

namespace TradeHubSharp.Rest.Responses
{
    public class TotalBalancesResponse : List<TotalBalancesResponse.TotalBalanceItem>
    {
        public class TotalBalanceItem
        {
            public string Available { get; set; }
            public string Order { get; set; }
            public string Position { get; set; }
            public string Denom { get; set; }
        }
    }
}
