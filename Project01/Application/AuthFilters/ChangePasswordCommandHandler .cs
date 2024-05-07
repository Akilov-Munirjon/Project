using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Project01.Application.AuthFilters
{
    public class ChangePasswordCommandHandler : IRequestHandler<ChangePasswordCommand, bool>
    {
        private readonly UserManager<IdentityUser> _userManager;

        public ChangePasswordCommandHandler(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager
                .FindByIdAsync(request.UserId) ?? throw new Exception("Пользователь не найден.");

            var result = await _userManager.ChangePasswordAsync(user, request.NewPassword, request.NewPassword);
            return result.Succeeded;

        }
    }
}
