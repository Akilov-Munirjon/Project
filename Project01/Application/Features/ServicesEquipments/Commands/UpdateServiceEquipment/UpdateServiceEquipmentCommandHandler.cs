using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;
using Project01.Application.Features.ServicesEquipments.Commands.UpdateServiceEquipment;

namespace Project01.Application.Features.ServiceEquipments.Commands.UpdateServiceEquipment
{
    public class UpdateServiceEquipmentCommandHandler : IRequestHandler<UpdateServiceEquipmentCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateServiceEquipmentCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateServiceEquipmentCommand request, CancellationToken cancellationToken)
        {
            var serviceEquipment = await _dbContext.ServiceEquipments
                .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

            _mapper.Map(request, serviceEquipment);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
