using FrontToBack.Models;
using FrontToBack.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            List<Objective> objective = new List<Objective> {
                new Objective{ Id=1, Title="Our Vision", Text="Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra."},
                new Objective{ Id=2, Title="Our Mission", Text="Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis."},
                new Objective{ Id=3, Title="Our Goal", Text="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor."},
            };

            AboutIndexViewModel models = new AboutIndexViewModel { Objectives = objective };

            return View(models);
        }
    }
}
