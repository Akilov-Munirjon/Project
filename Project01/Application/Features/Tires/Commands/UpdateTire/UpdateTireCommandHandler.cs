using MediatR;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Tires.Commands.UpdateTire;

public class UpdateTireCommandHandler : IRequestHandler<UpdateTireCommand>
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMapper _mapper;

    public UpdateTireCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdateTireCommand request, CancellationToken cancellationToken)
    {
        var tire = await _dbContext.Tires
            .FirstOrDefaultAsync(t => t.Id == request.Id, cancellationToken);

        _mapper.Map(request, tire);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
