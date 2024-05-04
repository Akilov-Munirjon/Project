using FluentValidation;
using Project01.Application.Features.ServicesEquipments.Commands.UpdateServiceEquipment;

namespace Project01.Application.Features.ServiceEquipments.Commands.UpdateServiceEquipment
{
    public class UpdateServiceEquipmentCommandValidator : AbstractValidator<UpdateServiceEquipmentCommand>
    {
        public UpdateServiceEquipmentCommandValidator()
        {
            RuleFor(x => x.ServiceName)
                .NotEmpty()
                .WithMessage("Идентификатор сервиса не должен быть пустым.");

            RuleFor(x => x.EquipmentName)
                .NotEmpty()
                .WithMessage("Идентификатор оборудования не должен быть пустым.");
        }
    }
}
