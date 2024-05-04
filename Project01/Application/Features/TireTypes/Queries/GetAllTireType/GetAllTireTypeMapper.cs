using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.TireTypes.Queries.GetAllTireType
{
    public class GetAllTireTypeMapper : Profile
    {
        public GetAllTireTypeMapper()
        {
            CreateMap<DiskType, GetAllTireTypeViewModel>();
        }
 
    }
}