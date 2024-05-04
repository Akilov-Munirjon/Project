using FluentValidation;

namespace Project01.Application.Features.DiskTypes.Commands
{
    public class CreateDiskTypeCommandValidaton : AbstractValidator<CreateDiskTypeCommand>
    {
        public CreateDiskTypeCommandValidaton()
        {
            RuleFor(x => x.Name)
                 .NotEmpty()
                 .NotNull()
                 .MaximumLength(100)
                 .WithMessage("Имя не может быть пустым");

            RuleFor(x => x.Size)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("Размер не может быть пустым.");

            RuleFor(x => x.Collor)
                 .NotEmpty()
                 .NotNull()
                 .WithMessage("Цвет не может быть пустым.");

        }
    }
}
