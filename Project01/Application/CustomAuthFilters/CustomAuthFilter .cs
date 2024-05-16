using Project01.Application.Tokens;

namespace Project01.Application.CustomAuthFilters
{
    public class AuthorizationFilter
    {
        private readonly RequestDelegate _next;

        private readonly TokenService _tokenService;

        public AuthorizationFilter(RequestDelegate next, TokenService tokenService)
        {
            _next = next;
            _tokenService = tokenService;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Request.Headers[_tokenService.HeaderName].FirstOrDefault();

            if (string.IsNullOrEmpty(token))
            {
                context.Response.StatusCode = 401;
                return;
            }

            if (!TokenValidator.Validate(token))
            {
                context.Response.StatusCode = 403;
                return;
            }

            await _next(context);
        }
    }
}