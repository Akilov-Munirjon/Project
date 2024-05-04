using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.ServicesEquipments.Commands.UpdateServiceEquipment
{
    public class UpdateServiceEquipmentMapper : Profile
    {
        public UpdateServiceEquipmentMapper()
        {
            CreateMap<UpdateServiceEquipmentCommand, ServiceEquipment>();
        }
    }
}
