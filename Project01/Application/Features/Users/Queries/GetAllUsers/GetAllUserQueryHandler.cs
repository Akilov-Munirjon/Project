using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUserQuery, List<GetAllUserViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllUserViewModel>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Users
                 .AsNoTracking()
                 .ProjectTo<GetAllUserViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}
