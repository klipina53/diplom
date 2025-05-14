using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace diplom.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Login(string email, string password, bool rememberMe, string returnUrl = null)
        {
            if (email == "test@example.com" && password == "123456")
            {
                HttpContext.Session.SetString("IsAuthenticated", "true");
                HttpContext.Session.SetString("UserEmail", email);

                return RedirectToAction("Profile", "Home");
            }

            TempData["LoginError"] = "Неверный логин или пароль";
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
