using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.DiskTypes.Commands.DeleteDiskType
{
    public class DeleteDiskTypeMapper : Profile
    {
        public DeleteDiskTypeMapper()
        {
            CreateMap<DeleteDiskTypeCommand, DiskType>();
        }
    }
}
