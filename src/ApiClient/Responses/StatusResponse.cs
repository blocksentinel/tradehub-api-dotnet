using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class StatusResponse
    {
        public string JsonRpc { get; set; }
        public int Id { get; set; }
        public ResultItem Result { get; set; }

        public class ResultItem
        {
            [JsonPropertyName("node_info")]
            public NodeInfoItem NodeInfo { get; set; }

            [JsonPropertyName("sync_info")]
            public SyncInfoItem SyncInfo { get; set; }

            [JsonPropertyName("validator_info")]
            public ValidatorInfoItem ValidatorInfo { get; set; }
        }

        public class NodeInfoItem
        {
            [JsonPropertyName("protocol_version")]
            public ProtocolVersionItem ProtocolVersion { get; set; }

            public string Id { get; set; }

            [JsonPropertyName("listen_addr")]
            public string ListenAddr { get; set; }

            public string Network { get; set; }
            public string Version { get; set; }
            public string Channels { get; set; }
            public string Moniker { get; set; }
            public OtherItem Other { get; set; }
        }

        public class ProtocolVersionItem
        {
            public string P2P { get; set; }
            public string Block { get; set; }
            public string App { get; set; }
        }

        public class OtherItem
        {
            [JsonPropertyName("tx_index")]
            public string TxIndex { get; set; }

            [JsonPropertyName("rpc_address")]
            public string RpcAddress { get; set; }
        }

        public class SyncInfoItem
        {
            [JsonPropertyName("latest_block_hash")]
            public string LatestBlockHash { get; set; }

            [JsonPropertyName("latest_app_hash")]
            public string LatestAppHash { get; set; }

            [JsonPropertyName("latest_block_height")]
            public string LatestBlockHeight { get; set; }

            [JsonPropertyName("latest_block_time")]
            public string LatestBlockTime { get; set; }

            [JsonPropertyName("earliest_block_hash")]
            public string EarliestBlockHash { get; set; }

            [JsonPropertyName("earliest_app_hash")]
            public string EarliestAppHash { get; set; }

            [JsonPropertyName("earliest_block_height")]
            public string EarliestBlockHeight { get; set; }

            [JsonPropertyName("earliest_block_time")]
            public string EarliestBlockTime { get; set; }

            [JsonPropertyName("catching_up")]
            public bool CatchingUp { get; set; }
        }

        public class ValidatorInfoItem
        {
            public string Address { get; set; }

            [JsonPropertyName("pub_key")]
            public PubKeyItem PubKey { get; set; }

            [JsonPropertyName("voting_power")]
            public string VotingPower { get; set; }
        }

        public class PubKeyItem
        {
            public string Type { get; set; }
            public string Value { get; set; }
        }
    }
}
