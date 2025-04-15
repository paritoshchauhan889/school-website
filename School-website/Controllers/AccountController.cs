using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using School_website.Models;
using School_website.ViewModels;

namespace School_website.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)           
        {   
            if(ModelState.IsValid)
            {
                var users = new ApplicationUser
                {
                    FullName = model.Name,
                    UserName = model.Email,
                    Email = model.Email
                };

                var result = await userManager.CreateAsync(users, model.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

            }
                return View(model);
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
