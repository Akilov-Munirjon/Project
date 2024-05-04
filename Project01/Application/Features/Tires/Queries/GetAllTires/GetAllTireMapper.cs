using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Tires.Queries.GetAllTires
{
    public class GetAllTireMapper : Profile
    {
        public GetAllTireMapper()
        {
            CreateMap<Tire, GetAllTireViewModel>();

        }
    }
}