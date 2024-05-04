using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Disks.Commands.UpdateDisk;

public class UpdateDiskCommandHandler : IRequestHandler<UpdateDiskCommand>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public UpdateDiskCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateDiskCommand request, CancellationToken cancellationToken)
    {
        var disk = await _dbContext.Disks
            .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

        _mapper.Map(request, disk);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
