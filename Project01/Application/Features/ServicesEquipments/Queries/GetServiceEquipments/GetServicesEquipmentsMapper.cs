using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.ServicesEquipments.Queries.GetServiceEquipments;

public class GetServicesEquipmentsMapper : Profile
{
    public GetServicesEquipmentsMapper()
    {
        CreateMap<ServiceEquipment, GetServicesEquipmentsViewModel>()
            .ForMember(x => x.ServiceName, opt => opt.MapFrom(x => x.Service.Name))
            .ForMember(x => x.EquipmentName, opt => opt.MapFrom(x => x.Equipment.Name));
    }
}
