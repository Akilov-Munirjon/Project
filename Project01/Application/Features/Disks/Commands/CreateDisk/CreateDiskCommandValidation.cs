using FluentValidation;
using Project01.Core.Controllers;

namespace Project01.Application.Features.Disks.Commands.CreateDisk;

public class CreateDiskCommandValidaton : AbstractValidator<CreateDiskCommand>
{
    public CreateDiskCommandValidaton()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull()
            .MaximumLength(100);

        RuleFor(x => x.Price)
            .NotEmpty()
            .WithMessage("Укажите ценну"); 

        RuleFor(x => x.DiskTypeId)
            .NotNull()
            .NotEmpty();
    }
}
