using FrontToBack.Models;
using FrontToBack.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Card> cards = new List<Card>
            {
                new Card {Id=1, FilePath="services-01.jpg",Title="UI/UX design",Text="UI/UX design text"},
                new Card {Id=2, FilePath="services-02.jpg",Title="Social Media",Text="Scoail Media text"},
                new Card {Id=3, FilePath="services-03.jpg",Title="Marketing",Text="Marketing text"},
                new Card {Id=4, FilePath="services-04.jpg",Title="Graphic",Text="Grpahic text"},
                new Card {Id=5, FilePath="services-05.jpg",Title="Graphic",Text="Grpahic text"}
            };

            HomeIndexViewModel model = new HomeIndexViewModel
            { Cards = cards };

            return View(model);
        }
    }
}
