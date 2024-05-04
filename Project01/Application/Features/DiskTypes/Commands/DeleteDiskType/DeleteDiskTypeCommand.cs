using MediatR;

namespace Project01.Application.Features.DiskTypes.Commands.DeleteDiskType
{
    public class DeleteDiskTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
    
}
