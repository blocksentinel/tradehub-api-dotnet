using System.Threading;
using System.Threading.Tasks;
using Refit;
using TradeHubSharp.Rest.Requests;

namespace TradeHubSharp.Rest
{
    public interface IPrivateApi
    {
        [Post("/txs")]
        Task CreateOrder(CreateOrderRequest request, CancellationToken cancellationToken = default);
    }
}
