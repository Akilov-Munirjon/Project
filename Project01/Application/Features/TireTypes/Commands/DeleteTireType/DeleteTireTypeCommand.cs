using MediatR;

namespace Project01.Application.Features.TireTypes.Commands.DeleteTireType
{
    public class DeleteTireTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
