using Microsoft.AspNetCore.Mvc;
using Project01.Core.Common.Filters;

namespace Project01.Core.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [TypeFilter(typeof(UserAutentificationFilter))]
    public class IdentitiesController : ControllerBase
    {
        [HttpPost("Login")]
        public IActionResult Login()
        {
            return Ok();
        }

        [HttpPost("ChangePassword")]
        public IActionResult ChangePassword()
        {
            return Ok("Пароль успешно изменен");
        }
    }
}

