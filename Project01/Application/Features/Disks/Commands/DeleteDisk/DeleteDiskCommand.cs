using MediatR;

namespace Project01.Application.Features.Disks.Commands.DeleteDisk
{
    public class DeleteDiskCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}