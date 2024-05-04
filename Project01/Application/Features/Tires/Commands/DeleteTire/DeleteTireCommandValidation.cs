using FluentValidation;

namespace Project01.Application.Features.Tires.Commands.DeleteTire
{
    public class DeleteTireCommandValidation : AbstractValidator<DeleteTireCommand>
    {
        public DeleteTireCommandValidation()
        {
            RuleFor(t => t.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Индификатор удаление шины не может быть пустым"); 

            RuleFor(t => t.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Имя удаление шины не может быть пустым");
        }
    }
}
