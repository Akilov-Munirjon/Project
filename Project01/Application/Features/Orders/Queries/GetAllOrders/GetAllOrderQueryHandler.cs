using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQuery, List<GetAllOrderViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllOrderQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllOrderViewModel>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Orders
                 .AsNoTracking()
                 .ProjectTo<GetAllOrderViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}
