using Microsoft.AspNetCore.Mvc;

namespace Project01.Core.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
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

