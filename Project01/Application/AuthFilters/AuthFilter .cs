using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

public class AuthFilter : IAuthorizationFilter
{
    private readonly IMemoryCache _cache;

    public AuthFilter(IMemoryCache cache)
    {
        _cache = cache;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = context.HttpContext.Request.Headers["Authorization"].FirstOrDefault();

        if (string.IsNullOrEmpty(token) || !_cache.TryGetValue(token, out _))
        {
            context.Result = new UnauthorizedResult();
        }
    }
}