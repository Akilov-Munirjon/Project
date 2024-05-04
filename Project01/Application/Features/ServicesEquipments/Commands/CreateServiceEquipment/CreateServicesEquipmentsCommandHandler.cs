using MediatR;
using AutoMapper;
using Project01.Infrastructure.Context;
using Project01.Domain.Entities;
using Project01.Application.Features.ServicesEquipments.Commands.CreateServiceEquipment;

namespace Project01.Application.Features.ServicesEquipments.Commands.CreateServicesEquipment
{
    public class CreateServicesEquipmentsCommandHandler : IRequestHandler<CreateServicesEquipmentsCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateServicesEquipmentsCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateServicesEquipmentsCommand request, CancellationToken cancellationToken)
        {
            var serviceEquipment = _mapper.Map<ServiceEquipment>(request);

            await _dbContext.ServiceEquipments.AddAsync(serviceEquipment, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return serviceEquipment.Id;
        }
    }
}

