using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Disks.Commands.DeleteDisk;

public class DeleteDiskCommandHandler : IRequestHandler<DeleteDiskCommand>
{
    private readonly ApplicationDbContext _dbContext;

    public DeleteDiskCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(DeleteDiskCommand request, CancellationToken cancellationToken)
    {
        var disk = await _dbContext.Disks
            .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                ?? throw new Exception($"Диск с идентификатором {request.Id} не найден."); 

        _dbContext.Disks.Remove(disk);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
