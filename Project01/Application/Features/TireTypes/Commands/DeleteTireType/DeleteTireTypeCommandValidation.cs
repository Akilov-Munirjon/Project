using FluentValidation;

namespace Project01.Application.Features.TireTypes.Commands.DeleteTireType
{
    public class DeleteTireTypeCommandValidator : AbstractValidator<DeleteTireTypeCommand>
    {
        public DeleteTireTypeCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Индификатор удаление шины не может быть пустым"); 
        }
    }
}
