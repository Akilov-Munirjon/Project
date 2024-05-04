using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.DiskTypes.Queries.GetAllDikType
{
    public class GetAllDiskTypeMapper : Profile
    {
        public GetAllDiskTypeMapper()
        {
            CreateMap<DiskType, GetAllDiskTypeViewModel>();
        }
    }
}
