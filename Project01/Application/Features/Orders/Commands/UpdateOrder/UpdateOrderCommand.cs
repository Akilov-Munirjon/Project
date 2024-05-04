using MediatR;

namespace Project01.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommand : IRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Numbercar { get; set; }
        public string Phonenumber { get; set; }
        
        public Guid UserId { get; set; }
        public Guid? TireId { get; set; }
        public Guid? DiskId { get; set; }
        public Guid ServiceId { get; set; }
    }
}
