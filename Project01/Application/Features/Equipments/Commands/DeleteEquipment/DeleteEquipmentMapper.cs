using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Equipments.Commands.DeleteEquipment
{
    public class DeleteEquipmentMapper : Profile
    {
        public DeleteEquipmentMapper()
        {
            CreateMap<DeleteEquipmentCommand, Equipment>();
        }
    }
}
