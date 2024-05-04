using FluentValidation;

namespace Project01.Application.Features.DiskTypes.Commands.DeleteDiskType
{
    public class DeleteDiskTypeCommandValidator : AbstractValidator<DeleteDiskTypeCommand>
    {
        public DeleteDiskTypeCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .NotNull()
                .WithMessage("Идентификатор типа диска не может быть пустым."); 
        }
    }
}
