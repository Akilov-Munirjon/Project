using AutoMapper;
using MediatR;
using Project01.Core.Controllers;
using Project01.Domain.Entities;
using Project01.Infrastructure.Context;

namespace Project01.test.Command.CreateDisk
{
    public class CreateDiskCommandHandler : IRequestHandler<CreateDiskCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateDiskCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateDiskCommand request, CancellationToken cancellationToken)
        {
            var disk = _mapper.Map<Disk>(request);

            _dbContext.Disks.Add(disk);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return disk.Id;
        }

    }
}