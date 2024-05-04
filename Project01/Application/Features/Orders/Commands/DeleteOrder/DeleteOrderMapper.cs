using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Orders.Commands.DeleteOrder
{
    public class DeleteOrderMapper : Profile
    {
        public DeleteOrderMapper()
        {
            CreateMap<DeleteOrderCommand, Order>();
        }
    }
}
