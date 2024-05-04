using FluentValidation;

namespace Project01.Application.Features.Tires.Commands.CreateTire
{
    public class CreateTireCommandValidator : AbstractValidator<CreateTireCommand>
    {
        public CreateTireCommandValidator()
        {
            RuleFor(t => t.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .WithMessage("Имя шины не может быть пустым");

            RuleFor(t => t.Price)
                .NotEmpty()
                .WithMessage("Цена шины не может быть пустым"); 

            RuleFor(t => t.Size)
                .NotEmpty()
                .WithMessage("Размер шины не может быть пустым");

            RuleFor(x => x.TireTypeId)
                .NotNull()
                .NotEmpty();
        }
    }
}

