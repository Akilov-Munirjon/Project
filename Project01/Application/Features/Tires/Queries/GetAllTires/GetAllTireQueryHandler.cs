using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Tires.Queries.GetAllTires;

public class GetAllTiresQueryHandler : IRequestHandler<GetAllTireQuery, List<GetAllTireViewModel>>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetAllTiresQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<GetAllTireViewModel>> Handle(GetAllTireQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Tires
                 .AsNoTracking()
                 .ProjectTo<GetAllTireViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
    }
}
