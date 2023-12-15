using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCLabs.DAL;
using MVCLabs.ViewModels.Home;

namespace MVCLabs.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _appDbContext.Sliders.ToListAsync();
            var services = await _appDbContext.Services.ToListAsync();

            HomeIndexViewModel model = new HomeIndexViewModel { 
                Silders = sliders,
                Services = services
            };

            return View(model);
        }
    }
}
