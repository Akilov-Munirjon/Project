using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Tires.Commands.CreateTire
{
    public class CreateTireMapper : Profile
    {
        public CreateTireMapper()
        {
            CreateMap<CreateTireCommand, Tire>();
        }
    }
}
