using Microsoft.AspNetCore.Mvc;

namespace MVCLabs.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
