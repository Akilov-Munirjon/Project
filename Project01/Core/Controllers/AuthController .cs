using Microsoft.AspNetCore.Mvc;
using Project01.Application.CustomAuthFilters;
using Project01.Application.Models;
using Project01.Domain.Filters;

namespace Project01.Core.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserService _userService;

        public AccountController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] User request)
        {
            if (_userService.ValidateUser(request.Login, request.Password))
            {
                return Ok("Авторизация успешна");
            }

            return Unauthorized("Неверный логин или пароль, или срок действия пароля истек");
        }

        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword([FromBody] ChangePasswordRequest request)
        {
            _userService.ChangePassword(request.CurrentLogin, request.NewPassword);

            return Ok("Пароль успешно изменен");
        }
    }
   
}

