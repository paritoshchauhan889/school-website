using Microsoft.AspNetCore.Mvc;

namespace School_website.Controllers
{
    public class StudentDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
