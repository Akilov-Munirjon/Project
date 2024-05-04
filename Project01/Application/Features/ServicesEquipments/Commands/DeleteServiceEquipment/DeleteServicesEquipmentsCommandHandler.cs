using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Application.Features.ServicesEquipments.Commands.DeleteServicesEquipment;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.ServiceEquipments.Commands.DeleteServiceEquipment
{
    public class DeleteServicesEquipmentsCommandHandler : IRequestHandler<DeleteServicesEquipmentsCommand>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteServicesEquipmentsCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteServicesEquipmentsCommand request, CancellationToken cancellationToken)
        {
            var serviceEquipment = await _dbContext.ServiceEquipments
                 .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                ?? throw new Exception($"serviceEquipment с идентификатором {request.Id} не найден.");

            _dbContext.ServiceEquipments.Remove(serviceEquipment);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }

    }
}
