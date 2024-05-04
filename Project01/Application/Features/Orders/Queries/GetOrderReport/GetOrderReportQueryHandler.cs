using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Orders.Queries.GetOrderReport
{
    public class GetOrderReportQueryHandler : IRequestHandler<GetOrderReportQuery, List<GetOrderReportViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetOrderReportQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetOrderReportViewModel>> Handle(GetOrderReportQuery request, CancellationToken cancellationToken)
        {
            DateTime startDate, endDate;
            DateTime saveUtcNow = DateTime.Now;

            switch (request.ReportType)
            {
                case 1:
                    startDate = DateTime.Today;
                    endDate = startDate.AddDays(1).AddSeconds(-1);
                    break;
                case 2:
                    startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek); 
                    endDate = startDate.AddDays(7).AddDays(-1); 
                    break;
                case 3:
                    startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    endDate = startDate.AddMonths(1).AddDays(-1);
                    break;          
                default:
                    throw new ArgumentException("Отчет не верный");
            }

            return await _dbContext.Orders
                .Where(o => o.CreatedAt >= startDate && o.CreatedAt < endDate)
                .ProjectTo<GetOrderReportViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}
