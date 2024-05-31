using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Project01.Application.CustomAuthFilters;

namespace Project01.Domain.Filters
{
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

            var token = context.HttpContext.Request.Headers["Custom-Token"].ToString();

            if (!_cache.TryGetValue(token, out User user))
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            if (!user.IsActive)
            {
                context.Result = new ForbidResult("Пользователь неактивен");
                return;
            }

            if ((DateTime.UtcNow - user.LastPasswordChangeDate).TotalDays > 30)
            {
                context.Result = new ForbidResult("Требуется смена пароля");
                return;
            }
        }
    }
}
