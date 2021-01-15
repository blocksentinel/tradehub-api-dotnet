using System.Threading;
using System.Threading.Tasks;
using Refit;
using TradeHubSharp.Rest.Enums;
using TradeHubSharp.Rest.Requests;
using TradeHubSharp.Rest.Responses;

namespace TradeHubSharp.Rest
{
    public interface IPublicApi
    {
        [Get("/get_tokens")]
        Task<TokensResponse> GetTokens(CancellationToken cancellationToken = default);

        [Get("/get_token")]
        Task<TokensResponse> GetToken(string token, CancellationToken cancellationToken = default);

        [Get("/get_markets")]
        Task<MarketsResponse> GetMarkets([AliasAs("market_type")] string marketType = null,
            [AliasAs("is_active")] bool? activeOnly = null, [AliasAs("is_settled")] bool? settledOnly = null,
            CancellationToken cancellationToken = default);

        [Get("/get_market")]
        Task<MarketResponse> GetMarket(string market, CancellationToken cancellationToken = default);

        [Get("/get_orderbook")]
        Task<OrderbookResponse> GetOrderbook(string market, int? limit = null, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_oracle_result")]
        Task<string> GetOracleResult(string id, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_oracle_results")]
        Task<string> GetOracleResults(string id, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_insurance_balance")]
        Task<string> GetInsuranceBalance(string id, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_orders")]
        Task<OrdersResponse> GetOrders(string account, CancellationToken cancellationToken = default);

        [Get("/get_order")]
        Task<OrdersResponse> GetOrder([AliasAs("order_id")] string orderId, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_positions")]
        Task<string> GetPositions(string account, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_position")]
        Task<string> GetPosition(string account, string market, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_leverage")]
        Task<string> GetLeverage(string account, string market, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_trades")]
        Task<string> GetTrades(string market, [AliasAs("before_id")] string beforeId, [AliasAs("after_id")] string afterId,
            [AliasAs("order_by")] string orderBy, string limit, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_trades_by_account")]
        Task<string> GetTradesByAccount([AliasAs("before_id")] string beforeId, [AliasAs("after_id")] string afterId,
            [AliasAs("order_by")] string orderBy, string limit, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_liquidations")]
        Task<string> GetLiquidations([AliasAs("before_id")] string beforeId, [AliasAs("after_id")] string afterId,
            [AliasAs("order_by")] string orderBy, string limit, CancellationToken cancellationToken = default);

        [Get("/get_balance")]
        Task<BalanceResponse> GetBalance(string account, CancellationToken cancellationToken = default);

        [Get("/get_positions_sorted_by_size")]
        Task<string> GetPositionsSortedBySize(string market, CancellationToken cancellationToken = default);

        [Get("/get_positions_sorted_by_risk")]
        Task<string> GetPositionsSortedByRisk(string market, CancellationToken cancellationToken = default);

        [Get("/get_positions_sorted_by_pnl")]
        Task<string> GetPositionsSortedByPnl(string market, CancellationToken cancellationToken = default);

        [Get("/candlesticks")]
        Task<CandlesticksResponse> GetCandlesticks(string market, CandlesticksResolution resolution, string from, string to,
            CancellationToken cancellationToken = default);

        [Get("/get_prices")]
        Task<PricesResponse> GetPrices(string market, CancellationToken cancellationToken = default);

        [Get("/get_market_stats")]
        Task<MarketStatsResponse> GetMarketStats(string market, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_rich_list")]
        Task<string> GetRichList(string token, CancellationToken cancellationToken = default);

        // TODO 20210113 MD: Unable to determine data structure at this time
        [Get("/get_top_r_profits")]
        Task<string> GetTopRProfits(string token, CancellationToken cancellationToken = default);

        [Get("/get_status")]
        Task<StatusResponse> GetStatus(CancellationToken cancellationToken = default);

        [Get("/get_block_time")]
        Task<string> GetBlockTime(CancellationToken cancellationToken = default);

        [Get("/get_all_validators")]
        Task<AllValidatorsResponse> GetAllValidators(CancellationToken cancellationToken = default);

        [Get("/get_delegation_rewards")]
        Task<DelegationRewardsResponse> GetDelegationRewards(string account, CancellationToken cancellationToken = default);

        [Get("/get_blocks")]
        Task<BlocksResponse> GetBlocks([AliasAs("before_id")] string beforeId = null, [AliasAs("after_id")] string afterId = null,
            [AliasAs("order_by")] string orderBy = null, string proposer = null, string limit = null,
            CancellationToken cancellationToken = default);

        [Get("/get_transactions")]
        Task<TransactionsResponse> GetTransactions(string address, TransactionsRequest request,
            CancellationToken cancellationToken = default);

        [Get("/get_transaction")]
        Task<TransactionResponse> GetTransaction(string hash, CancellationToken cancellationToken = default);

        [Get("/get_transaction_types")]
        Task<TransactionTypesResponse> GetTransactionTypes(CancellationToken cancellationToken = default);

        [Get("/get_total_balances")]
        Task<TotalBalancesResponse> GetTotalBalances(CancellationToken cancellationToken = default);

        [Get("/get_external_transfers")]
        Task<ExternalTransfersResponse> GetExternalTransfers(string account, CancellationToken cancellationToken = default);

        [Get("/get_account")]
        Task<AccountResponse> GetAccount(string account, CancellationToken cancellationToken = default);

        [Get("/get_profile")]
        Task<ProfileResponse> GetProfile(string account, CancellationToken cancellationToken = default);

        [Get("/get_address")]
        Task<string> GetAddress(string username, CancellationToken cancellationToken = default);

        [Get("/username_check")]
        Task<bool> GetUsernameCheck(string username, CancellationToken cancellationToken = default);
    }
}
