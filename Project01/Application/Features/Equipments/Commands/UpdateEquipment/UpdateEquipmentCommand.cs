using MediatR;

namespace Project01.Application.Features.Equipments.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommand : IRequest
    {
        public string Name { get; set; }

        public Guid Id { get; set; }
    }
}
