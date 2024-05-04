using MediatR;

namespace Project01.Application.Features.Tires.Commands.CreateTire
{
    public class CreateTireCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }

        public Guid TireTypeId { get; set; }
    }
}
