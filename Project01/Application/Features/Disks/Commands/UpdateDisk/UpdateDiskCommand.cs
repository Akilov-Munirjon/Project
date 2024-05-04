using MediatR;

namespace Project01.Application.Features.Disks.Commands.UpdateDisk;

public class UpdateDiskCommand : IRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Guid DiskTypeId { get; set; }
}
