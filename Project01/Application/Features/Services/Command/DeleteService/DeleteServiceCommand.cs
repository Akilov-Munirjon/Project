using MediatR;

namespace Project01.Application.Features.Services.Command.DeleteService;

public class DeleteServiceCommand : IRequest
{
    public Guid Id { get; set; }
}
