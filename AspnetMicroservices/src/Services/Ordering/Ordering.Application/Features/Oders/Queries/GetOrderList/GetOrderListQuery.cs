using MediatR;

namespace Ordering.Application.Features.Oders.Queries.GetOrderList
{
    public class GetOrderListQuery : IRequest<List<OrdersVm>>
    {
        public string UserName { get; set; }

        public GetOrderListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
    }
}
