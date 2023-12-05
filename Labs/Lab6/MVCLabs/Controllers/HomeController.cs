using Microsoft.AspNetCore.Mvc;

namespace MVCLabs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
