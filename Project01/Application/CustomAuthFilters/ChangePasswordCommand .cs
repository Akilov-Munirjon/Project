using MediatR;

namespace Project01.Application.CustomAuthFilters
{
    public class ChangePasswordCommand : IRequest<bool>
    {
        public string? UserId { get; set; }
        public string NewPassword { get; set; }


    }
}
