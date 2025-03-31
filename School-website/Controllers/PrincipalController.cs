using Microsoft.AspNetCore.Mvc;

namespace School_website.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
