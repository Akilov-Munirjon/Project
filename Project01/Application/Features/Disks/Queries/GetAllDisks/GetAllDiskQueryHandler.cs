using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Disks.Queries.GetAllDisks
{
    public class GetAllDiskQueryHandler : IRequestHandler<GetAllDiskQuery, List<GetAllDiskViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllDiskQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllDiskViewModel>> Handle(GetAllDiskQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Disks
                 .AsNoTracking()
                 .ProjectTo<GetAllDiskViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}