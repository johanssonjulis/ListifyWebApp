using Microsoft.AspNetCore.Mvc;

namespace ListifyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
