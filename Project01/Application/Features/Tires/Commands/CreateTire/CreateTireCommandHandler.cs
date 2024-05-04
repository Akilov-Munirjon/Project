using AutoMapper;
using MediatR;
using Project01.Domain.Entities;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.Tires.Commands.CreateTire
{
    public class CreateTireCommandHandler : IRequestHandler<CreateTireCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateTireCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateTireCommand request, CancellationToken cancellationToken)
        {
            var tire = _mapper.Map<Tire>(request);

            await _dbContext.Tires.AddAsync(tire, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return tire.Id;
        }
    }
}
