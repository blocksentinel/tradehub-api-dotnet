using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class DelegationRewardsResponse
    {
        public string Height { get; set; }
        public ResultItem Result { get; set; }

        public class ResultItem
        {
            public IEnumerable<RewardItem> Rewards { get; set; }
            public IEnumerable<AmountItem> Total { get; set; }
        }

        public class RewardItem
        {
            [JsonPropertyName("validator_address")]
            public string ValidatorAddress { get; set; }

            public IEnumerable<AmountItem> Reward { get; set; }
        }

        public class AmountItem
        {
            public string Denom { get; set; }
            public string Amount { get; set; }
        }
    }
}
