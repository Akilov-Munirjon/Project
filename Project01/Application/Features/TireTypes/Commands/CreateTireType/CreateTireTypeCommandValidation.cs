using FluentValidation;

namespace Project01.Application.Features.TireTypes.Commands.CreateTireType
{
    public class CreateTireTypeCommandValidation : AbstractValidator<CreateTireTypeCommand>
    {
        public CreateTireTypeCommandValidation()
        {
            RuleFor(x => x.Name)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("Имя не может быть пустым")
                 .MaximumLength(100);
        }
    }
}
