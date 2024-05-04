using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;


namespace Project01.Application.Features.Equipments.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommandHandler : IRequestHandler<UpdateEquipmentCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateEquipmentCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateEquipmentCommand request, CancellationToken cancellationToken)
        {
            var equipment = await _dbContext.Equipments.FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

            if (equipment == null)
            {
                throw new Exception($"Оборудование с идентификатором не найдено."); 
            }

            _mapper.Map(request, equipment);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
