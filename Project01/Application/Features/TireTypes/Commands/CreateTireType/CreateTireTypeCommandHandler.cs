using AutoMapper;
using MediatR;
using Project01.Domain.Entities;
using Project01.Infrastructure.Context;

namespace Project01.Application.Features.TireTypes.Commands.CreateTireType
{
    public class CreateTireTypeCommandHandler : IRequestHandler<CreateTireTypeCommand, Guid>
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public CreateTireTypeCommandHandler(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateTireTypeCommand request, CancellationToken cancellationToken)
        {
            var tireType = _mapper.Map<TireType>(request);

            await _dbContext.TireTypes.AddAsync(tireType, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return tireType.Id;
        }
    }
}
