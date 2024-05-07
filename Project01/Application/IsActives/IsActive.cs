using Microsoft.AspNetCore.Identity;

namespace Project01.Application.IsActives
{
    public class IsActive
    {
        private readonly UserManager<IdentityUser> _userManager;

        public IsActive(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);

            if (user != null && await _userManager.CheckPasswordAsync(user, password))
            {
                if (user.IsActive)
                {
                    var passwordChangedDate = await _userManager.GetPasswordChangeDateAsync(user);
                    if (passwordChangedDate.HasValue && (DateTime.Now - passwordChangedDate.Value).TotalDays > 30)
                    {
                        return false;
                    }

                    return true;
                }
            }

            return false;
        }
    }
}