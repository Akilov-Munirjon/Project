using Microsoft.AspNetCore.Identity;

namespace Project01.Application.IsActives
{
    public class IsActive
    {
        private readonly UserStatus<IdentityUser> _userStatus;

        public IsActive(UserStatus<IdentityUser> _userStatus)
        {
            _userStatus = _userStatus;
        }

        public async Task<bool> AuthenticateUserAsync(string username, string password)
        {
            var user = await _userStatus.FindByNameAsync(username);

            if (user != null && await _userStatus.CheckPasswordAsync(user, password))
            {
                if (user.IsActive)
                {
                    var passwordChangedDate = await _userStatus.GetPasswordChangeDateAsync(user);
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