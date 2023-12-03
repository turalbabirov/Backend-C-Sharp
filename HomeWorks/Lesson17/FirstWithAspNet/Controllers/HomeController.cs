using Microsoft.AspNetCore.Mvc;

namespace FirstWithAspNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
