using FluentValidation;

namespace Project01.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidation : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Имя не может пустым") 
                .MaximumLength(100)
                .WithMessage("Введите имя"); 

            RuleFor(x => x.Numbercar)
                .NotEmpty()
                .WithMessage("Введите номер машины")
                .MaximumLength(100);

            RuleFor(x => x.Phonenumber)
                .NotEmpty()
                .WithMessage("Введите номер телефона")
                .MaximumLength(100);
        }
    }
}
