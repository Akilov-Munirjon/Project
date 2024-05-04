using Project01.Core.Comman.Exceptions;

namespace Project01.Core.Comman.Middlewares
{
    public class ErrorMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorMiddleware> _logger;

        public ErrorMiddleware(RequestDelegate next, ILogger<ErrorMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                switch (ex)
                {
                    case NullDataException exception:
                        _logger.LogError($"Обнаружено пользовательское исключение: {ex.Message}");
                        break;
                    default:
                        _logger.LogError($"Данные не найдены: {ex.Message}");
                        break;
                }

                await context.Response.WriteAsync("Произошла ошибка. Пожалуйста, попробуйте позже.");
            }
        }
    }
}