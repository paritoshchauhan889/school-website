using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using School_website.Models;

namespace School_website.Controllers
{
    public class AccountController : Controller
    {   
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
        
    }
}
