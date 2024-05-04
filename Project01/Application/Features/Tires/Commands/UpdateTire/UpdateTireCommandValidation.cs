using FluentValidation;

namespace Project01.Application.Features.Tires.Commands.UpdateTire
{
    public class UpdateTireCommandValidator : AbstractValidator<UpdateTireCommand>
    {
        public UpdateTireCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Идентификатор не может быть пустым");

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Имя не может быть пустым "); 


            RuleFor(x => x.Price)
                 .NotNull()
                 .WithMessage("Цена не может быть пустой");


        }
    }
}