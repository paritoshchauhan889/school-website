using Microsoft.AspNetCore.Mvc;

namespace School_website.Controllers
{
    public class TeacherDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
