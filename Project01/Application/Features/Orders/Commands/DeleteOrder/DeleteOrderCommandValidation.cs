using FluentValidation;

namespace Project01.Application.Features.Orders.Commands.DeleteOrder
{
    public class DeleteOrderCommandValidation : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidation()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Удаление диска"); //
        }
    }
}
