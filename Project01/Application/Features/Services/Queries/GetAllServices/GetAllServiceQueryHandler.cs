using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Services.Queries.GetAllServices;

public class GetAllServiceQueryHandler : IRequestHandler<GetAllServiceQuery, List<GetAllServiceViewModel>>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public GetAllServiceQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<GetAllServiceViewModel>> Handle(GetAllServiceQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Services
                   .AsNoTracking()
                   .ProjectTo<GetAllServiceViewModel>(_mapper.ConfigurationProvider)
                   .ToListAsync(cancellationToken);
    }
}
