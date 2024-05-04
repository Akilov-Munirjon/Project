using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Tires.Commands.DeleteTire
{
    public class DeleteTireCommandHandler : IRequestHandler<DeleteTireCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;

        public DeleteTireCommandHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(DeleteTireCommand request, CancellationToken cancellationToken)
        {
            var tire = await _dbContext.Tires
               .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                ?? throw new Exception($"Tires с идентификатором {request.Id} не найден.");

            _dbContext.Tires.Remove(tire);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return tire.Id;
        }

    }
}