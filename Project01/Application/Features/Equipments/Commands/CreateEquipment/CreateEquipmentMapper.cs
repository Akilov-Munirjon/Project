using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Equipments.Commands.CreateEquipment
{
    public class CreateEquipmentMapper : Profile
    {
        public CreateEquipmentMapper()
        {
            CreateMap<CreateEquipmentCommand, Equipment>();
        }
    }
}
