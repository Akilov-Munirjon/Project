using MediatR;

namespace Project01.Application.Features.Users.Queries
{
    public class GetAllUserQuery : IRequest<List<GetAllUserViewModel>>
    {
    }
}
