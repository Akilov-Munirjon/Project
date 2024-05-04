using FluentValidation;
using Project01.Application.Features.Orders.Commands.CreateOrder;

namespace Project01.Application.Features.Disks.Commands.CreateDisk;

public class CreateOrderCommandValidaton : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidaton()
    {
        RuleFor(o => o.Name)
               .NotEmpty()
               .NotNull()
               .MaximumLength(100)
               .WithMessage("Имя заказа не может быть пустым");

        RuleFor(o => o.Numbercar)
               .NotEmpty()
               .WithMessage("Номер машины не может быть пустым") 
               .MaximumLength(100)
               .WithMessage("Введите номер машины"); 

        RuleFor(o => o.Phonenumber)
               .NotEmpty()
               .MaximumLength(100)
               .WithMessage("Номер телефон не может быть пустым");

        RuleFor(o => o.UserId)
               .NotEmpty()
               .WithMessage("Индификатор UserId не может быть пустым");

        RuleFor(o => o.TireId)
               .NotEmpty()
               .WithMessage("Индификатор TireId не может быть пустым");

        RuleFor(o => o.DiskId)
               .NotEmpty()
               .WithMessage("Индификатор DiskId не может быть пустым");
    }
}
