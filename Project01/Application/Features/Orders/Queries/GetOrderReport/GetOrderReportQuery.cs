using MediatR;

namespace Project01.Application.Features.Orders.Queries.GetOrderReport
{
    public class GetOrderReportQuery : IRequest<List<GetOrderReportViewModel>>
    {
        public int ReportType { get; set; }
    }
}