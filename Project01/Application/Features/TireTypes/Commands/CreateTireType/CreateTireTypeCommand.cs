using MediatR;

namespace Project01.Application.Features.TireTypes.Commands.CreateTireType
{
    public class CreateTireTypeCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
