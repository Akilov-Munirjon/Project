using AutoMapper;
using Project01.Application.Features.ServicesEquipments.Commands.CreateServiceEquipment;
using Project01.Domain.Entities;

namespace Project01.Application.Features.ServicesEquipments.Commands.CreateServicesEquipment
{
    public class CreateServicesEquipmentsMapper : Profile
    {
        public CreateServicesEquipmentsMapper()
        {
            CreateMap<CreateServicesEquipmentsCommand, ServiceEquipment>()
                ;

        }
    }
}
