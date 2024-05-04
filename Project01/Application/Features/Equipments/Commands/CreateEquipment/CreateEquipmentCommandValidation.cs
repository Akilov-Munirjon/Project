using FluentValidation;

namespace Project01.Application.Features.Equipments.Commands.CreateEquipment
{
    public class CreateEquipmentsCommandValidaton : AbstractValidator<CreateEquipmentCommand>
    {
        public CreateEquipmentsCommandValidaton()
        {
            RuleFor(e => e.Name)
                    .NotEmpty()
                    .NotNull()
                    .WithMessage("Имя не может быть пустым")
                    .MaximumLength(100);
        }
    }
}
