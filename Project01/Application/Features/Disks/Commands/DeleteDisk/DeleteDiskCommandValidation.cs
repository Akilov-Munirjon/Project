using FluentValidation;

namespace Project01.Application.Features.Disks.Commands.DeleteDisk;

public class DeleteDiskCommandValidator : AbstractValidator<DeleteDiskCommand>
{
    public DeleteDiskCommandValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .NotNull()
            .WithMessage("Удаление диска"); 
    }
}
