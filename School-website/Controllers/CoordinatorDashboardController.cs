using Microsoft.AspNetCore.Mvc;

namespace School_website.Controllers
{
    public class CoordinatorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
