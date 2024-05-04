using FluentValidation;

namespace Project01.Application.Features.Services.Command;

public class CreateServiceCommandValidation : AbstractValidator<CreateServiceCommand>
{
    public CreateServiceCommandValidation()
    {
        RuleFor(s => s.Name)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100);

        RuleFor(s => s.Price)
            .NotEmpty()
            .WithMessage("Цена не может быть пустым"); 

    }
}
