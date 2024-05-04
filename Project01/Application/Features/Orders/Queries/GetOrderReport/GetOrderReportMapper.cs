using AutoMapper;
using Project01.Domain.Entities;

namespace Project01.Application.Features.Orders.Queries.GetOrderReport
{
    public class GetOrderReportMapper : Profile
    {
        public GetOrderReportMapper()
        {
            CreateMap<Order, GetOrderReportViewModel>();
        }
    }
}
