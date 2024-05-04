using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderMapper : Profile
    {
        public UpdateOrderMapper()
        {
            CreateMap<UpdateOrderCommand, Order>();
        }
    }
}
