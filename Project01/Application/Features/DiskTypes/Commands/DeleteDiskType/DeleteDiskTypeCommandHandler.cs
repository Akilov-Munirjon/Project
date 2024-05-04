using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.DiskTypes.Commands.DeleteDiskType
{
    public class DeleteDiskTypeCommandHandler : IRequestHandler<DeleteDiskTypeCommand>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteDiskTypeCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteDiskTypeCommand request, CancellationToken cancellationToken)
        {
            var diskType = await _dbContext.DiskTypes
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                ?? throw new Exception($"Тип диска с идентификатором { request.Id } не найден."); 

            _dbContext.DiskTypes.Remove(diskType);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
