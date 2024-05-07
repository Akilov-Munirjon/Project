using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Security.Cryptography;
using System.Text;
using Project01.Infrastructure.Context;

public class UserController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    private readonly IMemoryCache _cache;

    public UserController(ApplicationDbContext dbContext, IMemoryCache cache)
    {
        _dbContext = dbContext;
        _cache = cache;
    }

    public IActionResult Authenticate(string username, string password)
    {
        var user = _dbContext.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == GetHash(password));

        if (user == null || !user.IsActive)
        {
            return Unauthorized();
        }

        var token = GenerateToken();

        _cache.Set(token, user, TimeSpan.FromMinutes(30));

        return Ok(new { Token = token });
    }

    private string GenerateToken()
    {
        using (var rng = RandomNumberGenerator.Create())
        {
            var bytes = new byte[32];
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
    }

    private string GetHash(string input)
    {
        using (var algorithm = SHA256.Create())
        {
            var hashBytes = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}