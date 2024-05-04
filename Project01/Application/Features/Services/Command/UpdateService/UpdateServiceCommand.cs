using MediatR;

namespace Project01.Application.Features.Services.Command.UpdateService
{
    public class UpdateServiceCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
