using MediatR;

namespace Project01.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServiceQuery : IRequest<List<GetAllServiceViewModel>>
    {
    }
}
