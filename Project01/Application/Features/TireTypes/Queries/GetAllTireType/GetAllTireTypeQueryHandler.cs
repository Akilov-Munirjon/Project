using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.TireTypes.Queries.GetAllTireType
{
    public class GetAllTireTypeQueryHandler : IRequestHandler<GetAllTireTypeQuery, List<GetAllTireTypeViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllTireTypeQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllTireTypeViewModel>> Handle(GetAllTireTypeQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.DiskTypes
                 .AsNoTracking()
                 .ProjectTo<GetAllTireTypeViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}
