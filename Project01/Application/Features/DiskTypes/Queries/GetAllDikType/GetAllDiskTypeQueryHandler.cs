using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.DiskTypes.Queries.GetAllDikType
{
    public class GetAllDiskTypeQueryHandler : IRequestHandler<GetAllDiskTypeQuery, List<GetAllDiskTypeViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllDiskTypeQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllDiskTypeViewModel>> Handle(GetAllDiskTypeQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.DiskTypes
                 .AsNoTracking()
                 .ProjectTo<GetAllDiskTypeViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}
