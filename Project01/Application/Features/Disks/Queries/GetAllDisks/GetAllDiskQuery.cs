using MediatR;

namespace Project01.Application.Features.Disks.Queries.GetAllDisks
{
    public class GetAllDiskQuery : IRequest<List<GetAllDiskViewModel>>
    {
    }
}