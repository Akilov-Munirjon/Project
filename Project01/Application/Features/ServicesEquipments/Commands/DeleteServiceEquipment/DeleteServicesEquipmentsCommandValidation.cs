using FluentValidation;
using Project01.Application.Features.ServicesEquipments.Commands.DeleteServicesEquipment;

namespace Project01.Application.Features.ServicesEquipments.Commands.DeleteServiceEquipment
{
    public class DeleteServicesEquipmentsCommandValidation : AbstractValidator<DeleteServicesEquipmentsCommand>
    {
        public DeleteServicesEquipmentsCommandValidation()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Индификатор не может быть пустым"); 
        }
    }
}
