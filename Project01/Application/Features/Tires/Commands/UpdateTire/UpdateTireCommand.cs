using MediatR;

namespace Project01.Application.Features.Tires.Commands.UpdateTire
{
    public class UpdateTireCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
    }
}
