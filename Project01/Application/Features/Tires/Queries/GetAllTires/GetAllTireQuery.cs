using MediatR;

namespace Project01.Application.Features.Tires.Queries.GetAllTires
{
    public class GetAllTireQuery : IRequest<List<GetAllTireViewModel>>
    {
    }
}
