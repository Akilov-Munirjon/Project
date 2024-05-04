using FluentValidation;

namespace Project01.Application.Features.TireTypes.Commands.UpdateTireType
{
    public class UpdateTireTypeCommandValidation : AbstractValidator<UpdateTireTypeCommand>
    {
        public UpdateTireTypeCommandValidation()
        {
            RuleFor(x => x.Id)
                   .NotEmpty()
                   .NotNull()
                   .WithMessage("Индифкатор не может быть путым");

            RuleFor(x => x.Name)
                   .NotEmpty()
                   .WithMessage("Имя не может быть пустым"); 
        }
    }
}
