using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Tires.Commands.UpdateTire;

public class UpdateTireMapper : Profile
{
    public UpdateTireMapper()
    {
        CreateMap<UpdateTireCommand, Tire>();
    }
}
