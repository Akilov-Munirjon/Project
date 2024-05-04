using FluentValidation;

namespace Project01.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandValidation : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidation()
        {
            RuleFor(u => u.Id)
                 .NotEmpty()
                 .NotNull();

            RuleFor(u => u.FirstName)
                    .NotEmpty()
                    .WithMessage("Имя не может быть пустым");

            RuleFor(u => u.LastName)
                  .NotEmpty()
                  .WithMessage("Фамилия не может быть пустым");

            RuleFor(u => u.MiddleName)
                    .NotEmpty()
                    .WithMessage("Очество не может быть пустым");

            RuleFor(u => u.Password)
                    .NotEmpty()
                    .WithMessage("Пароль не может быть пустым");

            RuleFor(u => u.Login)
                    .NotEmpty()
                    .WithMessage("Логин не может быть пустым");
        }
    }
}
