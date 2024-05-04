using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Disks.Commands.DeleteDisk;

public class DeleteDiskMapper : Profile
{
    public DeleteDiskMapper()
    {
        CreateMap<DeleteDiskCommand, Disk>();
    }
}
