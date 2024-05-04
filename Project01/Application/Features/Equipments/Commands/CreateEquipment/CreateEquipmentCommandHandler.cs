using AutoMapper;
using MediatR;
using Project01.Infrastructure.Context;
using Project01.Domain.Entities;


namespace Project01.Application.Features.Equipments.Commands.CreateEquipment
{
    public class CreateEquipmentCommandHandler : IRequestHandler<CreateEquipmentCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateEquipmentCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateEquipmentCommand request, CancellationToken cancellationToken)
        {
            var equipment = _mapper.Map<Equipment>(request);

            await _dbContext.Equipments.AddAsync(equipment, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return equipment.Id;
        }
    }
}
