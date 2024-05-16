using MediatR;
using Microsoft.AspNetCore.Identity;


namespace Project01.Application.CustomAuthFilters
{
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, bool>
    {
        private readonly UserStatus<IdentityUser> _userStatus;

        public ChangePasswordCommandHandler(UserManager<IdentityUser> userManager)
        {
            _userStatus = userStatus;
        }

        public async Task<bool> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userStatus
                .FindByIdAsync(request.UserId) ?? throw new Exception("Пользователь не найден.");

            var result = await _userStatus.ChangePasswordAsync(user, request.NewPassword, request.NewPassword);

            return result.Succeeded;
        }
    }
}
