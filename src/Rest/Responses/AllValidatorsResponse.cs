using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class AllValidatorsResponse : List<AllValidatorsResponse.ValidatorItem>
    {
        public class ValidatorItem
        {
            public string OperatorAddress { get; set; }
            public string ConsPubKey { get; set; }
            public bool Jailed { get; set; }
            public int Status { get; set; }
            public string Tokens { get; set; }
            public string DelegatorShares { get; set; }
            public DescriptionItem Description { get; set; }
            public int UnbondingHeight { get; set; }
            public object UnbondingCompletionTime { get; set; }
            public CommissionItem Commission { get; set; }
            public string MinSelfDelegation { get; set; }
            public string ConsAddress { get; set; }
            public string ConsAddressByte { get; set; }
            public string WalletAddress { get; set; }
            public string BondStatus { get; set; }
        }

        public class DescriptionItem
        {
            public string Moniker { get; set; }
            public string Identity { get; set; }
            public string Website { get; set; }

            [JsonPropertyName("security_contact")]
            public string SecurityContact { get; set; }

            public string Details { get; set; }
        }

        public class CommissionItem
        {
            [JsonPropertyName("commission_rates")]
            public CommissionRateItem CommissionRates { get; set; }

            [JsonPropertyName("update_time")]
            public string UpdateTime { get; set; }
        }

        public class CommissionRateItem
        {
            public string Rate { get; set; }

            [JsonPropertyName("max_rate")]
            public string MaxRate { get; set; }

            [JsonPropertyName("max_change_rate")]
            public string MaxChangeRate { get; set; }
        }
    }
}
