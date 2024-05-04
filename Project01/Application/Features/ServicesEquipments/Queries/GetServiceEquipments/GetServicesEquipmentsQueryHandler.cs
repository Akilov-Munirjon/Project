using MediatR;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.ServicesEquipments.Queries.GetServiceEquipments
{
    public class GetServicesEquipmentsQueryHandler : IRequestHandler<GetServicesEquipmentsQuery, List<GetServicesEquipmentsViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetServicesEquipmentsQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetServicesEquipmentsViewModel>> Handle(GetServicesEquipmentsQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.ServiceEquipments
                 .AsNoTracking()
                 .ProjectTo<GetServicesEquipmentsViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}
