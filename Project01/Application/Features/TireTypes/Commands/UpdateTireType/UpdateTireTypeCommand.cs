using MediatR;

namespace Project01.Application.Features.TireTypes.Commands.UpdateTireType
{
    public class UpdateTireTypeCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
