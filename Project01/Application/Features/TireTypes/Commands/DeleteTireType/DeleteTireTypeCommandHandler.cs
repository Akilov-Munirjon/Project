using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.TireTypes.Commands.DeleteTireType
{
    public class DeleteTireTypeCommandHandler : IRequestHandler<DeleteTireTypeCommand>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteTireTypeCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteTireTypeCommand request, CancellationToken cancellationToken)
        {
            var diskType = await _dbContext.DiskTypes
                 .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                ?? throw new Exception($"Тип шины с идентификатором { request.Id } не найден.");

            _dbContext.DiskTypes.Remove(diskType);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
