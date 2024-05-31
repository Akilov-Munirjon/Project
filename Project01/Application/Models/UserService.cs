using Project01.Application.CustomAuthFilters;
using System.Security.Cryptography;
using System.Text;

namespace Project01.Application.Models
{
    public class UserService
    {
        private readonly List<User> _users;

        public UserService()
        {
            _users = new List<User>
            {
                new User
                {
                    Login = "user1",
                    Password = HashPassword("password123"),
                    IsActive = true,
                    LastPasswordChangeDate = DateTime.UtcNow.AddDays(-31) 
                }
            };
        }

        public bool ValidateUser(string userName, string password)
        {
            var user = _users.FirstOrDefault(u => u.Login == userName);

            if (user == null || !user.IsActive)
            {
                return false;
            }

            if (!VerifyPassword(user.Password, password))
            {
                return false;
            }

            if (IsPasswordExpired(user))
            {
                
                return false;
            }

            return true;
        }

        public bool IsPasswordExpired(User user)
        {
            return (DateTime.UtcNow - user.LastPasswordChangeDate).TotalDays > 30;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                var builder = new StringBuilder();

                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private bool VerifyPassword(string storedHash, string password)
        {
            var hash = HashPassword(password);
            return storedHash == hash;
        }

        public void ChangePassword(string login, string newPassword)
        {
            var user = _users.FirstOrDefault(u => u.Login == login);
            if (user != null)
            {
                user.Password = HashPassword(newPassword);

                user.LastPasswordChangeDate = DateTime.UtcNow;
            }
        }
    }
}
