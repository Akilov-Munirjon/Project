using AutoMapper;
using Project01.Application.Features.ServicesEquipments.Commands.DeleteServicesEquipment;
using Project01.Domain.Entities;

namespace Project01.Application.Features.ServicesEquipments.Commands.DeleteServiceEquipment
{
    public class DeleteServicesEquipmentsMapper : Profile
    {
        public DeleteServicesEquipmentsMapper()
        {
            CreateMap<DeleteServicesEquipmentsCommand, ServiceEquipment>();
        }
    }
}
