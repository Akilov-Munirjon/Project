using FluentValidation;

namespace Project01.Application.Features.DiskTypes.Commands.UpdateDiskType
{
    public class UpdateDiskTypeCommandValidation : AbstractValidator<UpdateDiskTypeCommand>
    {
        public UpdateDiskTypeCommandValidation()
        {
            RuleFor(x => x.Id)
                   .NotEmpty()
                   .NotNull();

            RuleFor(x => x.Name)
                   .NotEmpty()
                   .WithMessage("Имя не может быть пустым"); 

            RuleFor(x => x.Size)
                   .NotEmpty()
                   .WithMessage("Размер не может быть пустым"); 

            RuleFor(x => x.Collor)
                   .NotEmpty()
                   .WithMessage("Цвет не может быть пустым"); 
        }
    }
}
