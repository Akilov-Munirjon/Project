using FluentValidation;

namespace Project01.Application.Features.Services.Command.UpdateService
{
    public class UpdateServiceCommandValidator : AbstractValidator<UpdateServiceCommand>
    {
        public UpdateServiceCommandValidator()
        {
            RuleFor(s => s.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Индификатор UpdateService не может быть пустым"); 

            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("Имя UpdateService не может быть пустым");


            RuleFor(s => s.Price)
                 .NotNull()
                 .WithMessage("Цена UpdateService не может быть пустым"); 
        }
    }
}
