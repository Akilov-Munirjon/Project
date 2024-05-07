using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.Infrastructure.Context;

namespace Project01.Application.AuthFilters
{
    public class Authenticate
    {
        private readonly ApplicationDbContext _dbContext;

        public Authenticate(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

        }
        public async Task<string?> Authenticate(string username, string password)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null || !user.IsActive || !VerifyPassword(password, user.Password))
            {
                return null;
            }
        }

        private bool VerifyPassword(string password1, string password2)
        {
            throw new NotImplementedException();
        }
    }
}
