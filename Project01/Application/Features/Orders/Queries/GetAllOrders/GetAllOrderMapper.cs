using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrderMapper : Profile
    {
        public GetAllOrderMapper()
        {
            CreateMap<Order, GetAllOrderViewModel>()
                .ForMember(x => x.UserFirstName, opt => opt.MapFrom(x => x.User.FirstName));
        }
    }
}
