using System;
using System.Text.Json.Serialization;

namespace TradeHubSharp.Rest.Responses
{
    public class MarketResponse
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }

        [JsonPropertyName("market_type")]
        public string MarketType { get; set; }

        [JsonPropertyName("base")]
        public string Base { get; set; }

        [JsonPropertyName("base_name")]
        public string BaseName { get; set; }

        [JsonPropertyName("base_precision")]
        public int BasePrecision { get; set; }

        public string Quote { get; set; }

        [JsonPropertyName("quote_name")]
        public string QuoteName { get; set; }

        [JsonPropertyName("quote_precision")]
        public int QuotePrecision { get; set; }

        [JsonPropertyName("lot_size")]
        public string LotSize { get; set; }

        [JsonPropertyName("tick_size")]
        public string TickSize { get; set; }

        [JsonPropertyName("min_quantity")]
        public string MinQuantity { get; set; }

        [JsonPropertyName("maker_fee")]
        public string MakerFee { get; set; }

        [JsonPropertyName("taker_fee")]
        public string TakerFee { get; set; }

        [JsonPropertyName("risk_step_size")]
        public string RiskStepSize { get; set; }

        [JsonPropertyName("initial_margin_base")]
        public string InitialMarginBase { get; set; }

        [JsonPropertyName("initial_margin_step")]
        public string InitialMarginStep { get; set; }

        [JsonPropertyName("maintenance_margin_ratio")]
        public string MaintenanceMarginRatio { get; set; }

        [JsonPropertyName("max_liquidation_order_ticket")]

        public string MaxLiquidationOrderTicket { get; set; }

        [JsonPropertyName("max_liquidation_order_duration")]
        public int MaxLiquidationOrderDuration { get; set; }

        [JsonPropertyName("impact_size")]
        public string ImpactSize { get; set; }

        [JsonPropertyName("mark_price_band")]
        public int MarkPriceBand { get; set; }

        [JsonPropertyName("last_price_protected_band")]
        public int LastPriceProtectedBand { get; set; }

        [JsonPropertyName("index_oracle_id")]
        public string IndexOracleId { get; set; }

        [JsonPropertyName("expiry_time")]
        public DateTimeOffset ExpiryTime { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("is_settled")]
        public bool IsSettled { get; set; }

        [JsonPropertyName("closed_block_height")]
        public int ClosedBlockHeight { get; set; }

        [JsonPropertyName("created_block_height")]
        public int CreatedBlockHeight { get; set; }
    }
}
