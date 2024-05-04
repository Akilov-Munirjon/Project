using AutoMapper;
using Project01.Core.Controllers;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Disks.Commands.CreateDisk;

public class CreateDiskMapper : Profile
{
    public CreateDiskMapper()
    {
        CreateMap<CreateDiskCommand, Disk>();
    }
}
