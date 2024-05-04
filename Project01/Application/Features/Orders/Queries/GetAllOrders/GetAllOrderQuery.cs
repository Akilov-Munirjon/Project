using MediatR;

namespace Project01.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrderQuery : IRequest<List<GetAllOrderViewModel>>
    {
    }
}
