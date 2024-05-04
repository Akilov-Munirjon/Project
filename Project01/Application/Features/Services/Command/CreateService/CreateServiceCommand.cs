using MediatR;

namespace Project01.Application.Features.Services.Command
{
    public class CreateServiceCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
