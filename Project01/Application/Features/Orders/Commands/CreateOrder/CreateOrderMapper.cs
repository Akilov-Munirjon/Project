using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderMapper : Profile
    {
        public CreateOrderMapper()
        {
            CreateMap<CreateOrderCommand, Order>();
        }
    }
}
