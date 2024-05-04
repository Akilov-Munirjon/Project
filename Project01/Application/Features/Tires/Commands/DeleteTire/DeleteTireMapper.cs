using AutoMapper;
using Project01.Application.Features.Tires.Commands.CreateTire;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Tires.Commands.DeleteTire
{
    public class DeleteTireMapper : Profile
    {
        public DeleteTireMapper()
        {
            CreateMap<CreateTireCommand, Tire>();
        }
    }
}
