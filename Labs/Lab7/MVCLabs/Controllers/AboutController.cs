using Microsoft.AspNetCore.Mvc;

namespace MVCLabs.Controllers
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
