using FluentValidation;

namespace Project01.Application.Features.Equipments.Commands.DeleteEquipment
{
    public class DeleteEquipmentCommandValidator : AbstractValidator<DeleteEquipmentCommand>
    {
        public DeleteEquipmentCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Идентификатор типа диска не может быть пустым."); 
        }
    }
}
