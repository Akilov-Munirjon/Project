using MediatR;

namespace Project01.Application.Features.ServicesEquipments.Commands.CreateServiceEquipment
{
    public class CreateServicesEquipmentsCommand : IRequest<Guid>
    {
        public Guid ServiceId { get; set; }
        public Guid EquipmentId { get; set; }
    }
}
