using FluentValidation;

namespace Project01.Application.Features.Equipments.Commands.UpdateEquipment
{
    public class UpdateEquipmentCommandValidator : AbstractValidator<UpdateEquipmentCommand>
    {
        public UpdateEquipmentCommandValidator()
        {
            RuleFor(x => x.Id)
                    .NotEmpty()
                    .NotNull();

            RuleFor(x => x.Name)
                  .NotEmpty()
                  .WithMessage("Имя не может быть пустым"); 
        }
    }
}
