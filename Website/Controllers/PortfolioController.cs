using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult MVC()
        {
            return View();
        }

        public IActionResult Razor()
        {
           return View();
        }

        public IActionResult Blazor() 
        { 
            return View();
        }

        public IActionResult WebApi()
        {
            return View();
        }

    }
}
