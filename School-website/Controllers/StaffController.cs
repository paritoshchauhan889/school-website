using Microsoft.AspNetCore.Mvc;

namespace School_website.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
