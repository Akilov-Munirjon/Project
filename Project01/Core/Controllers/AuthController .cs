using Microsoft.AspNetCore.Mvc;
using Project01.Application.IsActives;

namespace Project01.Core.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserStatus _userStatus;

        public AuthController(UserStatus _userStatus)
        {
            this._userStatus = _userStatus;
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (_userStatus.IsValidUser(username, password))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
        }
    }

}
