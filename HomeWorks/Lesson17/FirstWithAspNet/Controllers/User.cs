using Microsoft.AspNetCore.Mvc;

namespace FirstWithAspNet.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name1 = "Mark";
            ViewBag.Surname1 = "Otto";
            ViewBag.Age1 = 21;
            ViewBag.Country1 = "England";
            ViewBag.PhoneNumber1 = "1212631823981";

            ViewBag.Name2 = "Jacob";
            ViewBag.Surname2 = "Thornton";
            ViewBag.Age2 = 31;
            ViewBag.Country2 = "Island";
            ViewBag.PhoneNumber2 = "213123123124";

            ViewBag.Name3 = "Larry";
            ViewBag.Surname3 = "The Bird";
            ViewBag.Age3 = 41;
            ViewBag.Country3 = "Scotland";
            ViewBag.PhoneNumber3 = "331232424123";

            return View();
        }
    }
}
