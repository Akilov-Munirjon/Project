using MediatR;

namespace Project01.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Numbercar { get; set; }
        public string Phonenumber { get; set; }

        public Guid UserId { get; set; }
        public Guid? TireId { get; set; }
        public Guid? DiskId { get; set; }
        public Guid ServiceId { get; set; }
    }
}
