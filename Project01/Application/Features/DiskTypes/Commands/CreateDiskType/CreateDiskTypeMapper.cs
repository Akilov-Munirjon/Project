using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.DiskTypes.Commands
{
    public class CreateDiskTypeMapper : Profile
    {
        public CreateDiskTypeMapper()
        {
            CreateMap<CreateDiskTypeCommand, DiskType>();
        }
    }
}
