using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Project01.Application.IsActives;

public class CustomAuthorizationFilter : IAuthorizationFilter
{
    private readonly IMemoryCache _cache;

    public CustomAuthorizationFilter(IMemoryCache cache)
    {
        _cache = cache;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        if (!context.HttpContext.Request.Headers.ContainsKey("Custom-Token"))
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var token = context.HttpContext.Request.Headers["Custom-Token"];

        if (!_cache.TryGetValue(token, out string userData))
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var user = Newtonsoft.Json.JsonConvert.DeserializeObject<UserData>(userData);
        if (!user.IsActive)
        {
            context.Result = new ForbidResult();
            return;
        }

        if (user.AuthenticatedTime.AddHours(1) < DateTime.Now)
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
