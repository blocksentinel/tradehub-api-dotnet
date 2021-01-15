using System.Threading;
using System.Threading.Tasks;
using Refit;
using TradeHub.Rest.Requests;

namespace TradeHub.Rest
{
    public interface IPrivateApi
    {
        [Post("/txs")]
        Task CreateOrder(CreateOrderRequest request, CancellationToken cancellationToken = default);
    }
}
