using FluentValidation;

namespace Project01.Application.Features.Disks.Commands.UpdateDisk;

public class UpdateDiskCommandValidator : AbstractValidator<UpdateDiskCommand>
{
    public UpdateDiskCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .NotNull();

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Имя диска не может быть пустым."); 


        RuleFor(x => x.Price)
             .NotNull()
             .WithMessage("Цена не может быть пустой");


    }
}
