using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Equipments.Queries.GetAllEquipment
{
    public class GetAllEquipmentMapper : Profile
    {
        public GetAllEquipmentMapper()
        {
            CreateMap<Equipment, GetAllEquipmentViewModel>();

        }
    }
}
