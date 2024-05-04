using MediatR;

namespace Project01.Application.Features.Tires.Commands.DeleteTire;

public class DeleteTireCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; } 
}
