using FluentValidation;

namespace Project01.Application.Features.Users.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(u => u.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Индификатор не может быть пустым");
        }
    }
}
