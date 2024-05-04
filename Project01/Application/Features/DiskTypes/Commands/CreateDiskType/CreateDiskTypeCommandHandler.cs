using AutoMapper;
using MediatR;
using Project01.Domain.Entities;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.DiskTypes.Commands
{
    public class CreateDiskTypeCommandHandler : IRequestHandler<CreateDiskTypeCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateDiskTypeCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateDiskTypeCommand request, CancellationToken cancellationToken)
        {
            var diskType = _mapper.Map<DiskType>(request);

            await _dbContext.DiskTypes.AddAsync(diskType, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return diskType.Id;
        }
    }
}
