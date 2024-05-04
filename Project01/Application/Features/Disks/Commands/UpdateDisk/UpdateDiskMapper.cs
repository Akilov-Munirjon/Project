using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Disks.Commands.UpdateDisk;

public class UpdateDiskMapper : Profile
{
    public UpdateDiskMapper()
    {
        CreateMap<UpdateDiskCommand, Disk>();
    }
}
