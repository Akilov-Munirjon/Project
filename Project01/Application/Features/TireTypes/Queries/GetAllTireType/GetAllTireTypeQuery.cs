using MediatR;

namespace Project01.Application.Features.TireTypes.Queries.GetAllTireType
{
    public class GetAllTireTypeQuery : IRequest<List<GetAllTireTypeViewModel>>
    {
    }
}
