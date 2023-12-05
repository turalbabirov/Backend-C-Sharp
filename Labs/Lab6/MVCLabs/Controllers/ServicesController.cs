using Microsoft.AspNetCore.Mvc;

namespace MVCLabs.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
