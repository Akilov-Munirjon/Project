using MediatR;
using Project01.Infrastructure.Context;
using Project01.Domain.Entities;
using Project01.Application.Features.Services.Command;
using AutoMapper;

namespace Project01.Application.Features.Services.Commands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateServiceCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = _mapper.Map<Service>(request);

            await _dbContext.Services.AddAsync(service, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return service.Id;
        }
    }
}
