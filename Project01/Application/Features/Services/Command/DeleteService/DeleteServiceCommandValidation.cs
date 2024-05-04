using FluentValidation;

namespace Project01.Application.Features.Services.Command.DeleteService;

public class DeleteServiceCommandValidation : AbstractValidator<DeleteServiceCommand>
{
    public DeleteServiceCommandValidation()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("Индификатор Service не может быть пустым "); 
    }
}
