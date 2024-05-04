using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.DiskTypes.Commands.UpdateDiskType
{
    public class UpdateDiskTypeCommandHandler : IRequestHandler<UpdateDiskTypeCommand>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public UpdateDiskTypeCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateDiskTypeCommand request, CancellationToken cancellationToken)
        {
            var diskType = await _dbContext.DiskTypes
                .FirstOrDefaultAsync(d => d.Id == request.Id, cancellationToken);

            _mapper.Map(request, diskType);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
