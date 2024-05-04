using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Application.Features.Equipments.Queries.GetAllEquipment;
using Project01.Infrastructure.Context;


namespace Project01.Application.Features.Equipments.Queries.GetAllEquipments
{
    public class GetAllEquipmentsQueryHandler : IRequestHandler<GetAllEquipmentQuery, List<GetAllEquipmentViewModel>>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetAllEquipmentsQueryHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<GetAllEquipmentViewModel>> Handle(GetAllEquipmentQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.Equipments
                 .AsNoTracking()
                 .ProjectTo<GetAllEquipmentViewModel>(_mapper.ConfigurationProvider)
                 .ToListAsync(cancellationToken);
        }
    }
}
