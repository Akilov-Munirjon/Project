using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.DiskTypes.Commands.UpdateDiskType
{
    public class UpdateDiskTypeMapper : Profile
    {
        public UpdateDiskTypeMapper()
        {
            CreateMap<UpdateDiskTypeCommand, DiskType>();
        }
    }
}
