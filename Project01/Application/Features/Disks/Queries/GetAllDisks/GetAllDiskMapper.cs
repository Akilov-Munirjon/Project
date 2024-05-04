using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Disks.Queries.GetAllDisks
{
    public class GetAllDiskMapper : Profile
    {
        public GetAllDiskMapper()
        {
            CreateMap<Disk, GetAllDiskViewModel>();
        }
    }
}