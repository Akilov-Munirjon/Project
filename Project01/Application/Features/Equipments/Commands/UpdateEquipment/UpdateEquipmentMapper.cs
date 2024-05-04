using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Equipments.Commands.UpdateEquipment
{
    public class UpdateEquipmentMapper : Profile
    {
        public UpdateEquipmentMapper()
        {
            CreateMap<UpdateEquipmentCommand, Equipment>();
        }
    }
}
