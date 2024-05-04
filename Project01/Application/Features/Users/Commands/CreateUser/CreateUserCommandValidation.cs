using FluentValidation;

namespace Project01.Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandValidation : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidation()
        {
            RuleFor(o => o.FirstName)
                 .NotEmpty()
                 .NotNull()
                 .MaximumLength(100)
                 .WithMessage("Имя не может быть пустым");

            RuleFor(o => o.LastName)
                 .NotNull()
                 .MaximumLength(100)
                 .WithMessage("LastName не может быть пустым"); 

            RuleFor(o => o.MiddleName)
                 .NotNull()
                 .MaximumLength(100)
                 .WithMessage("Отчетсво не может быть пустым"); 

            RuleFor(o => o.Password)
                 .NotNull()
                 .MaximumLength(100)
                 .WithMessage("Пароль не может быть пустым");

            RuleFor(o => o.Login)
                 .NotNull()
                 .MaximumLength(100)
                 .WithMessage("Логин не может быть пустым");
        }
    }
}
