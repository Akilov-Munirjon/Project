using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;


namespace Project01.Application.Features.Services.Command.DeleteService;

public class DeleteServiceCommandHandler : IRequestHandler<DeleteServiceCommand>
{
    private readonly ApplicationDbContext _dbContext;

    public DeleteServiceCommandHandler(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Unit> Handle(DeleteServiceCommand request, CancellationToken cancellationToken)
    {
        var service = await _dbContext.Services
                  .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken)
                 ?? throw new Exception($"Service с идентификатором {request.Id} не найден.");

        _dbContext.Services.Remove(service);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }

}
