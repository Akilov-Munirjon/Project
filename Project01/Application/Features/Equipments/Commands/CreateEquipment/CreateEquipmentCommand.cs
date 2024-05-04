using MediatR;

namespace Project01.Application.Features.Equipments.Commands.CreateEquipment
{
    public class CreateEquipmentCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
