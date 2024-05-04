using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Services.Queries.GetAllServices
{
    public class GetAllServiceMapper : Profile
    {
        public GetAllServiceMapper()
        {
            CreateMap<Service, GetAllServiceViewModel>();
        }
    }
}
