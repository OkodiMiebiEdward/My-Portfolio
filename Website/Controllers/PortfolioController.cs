using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Web()
        {
            return View();
        }

        public IActionResult Mobile()
        {
            return View();
        }

        public IActionResult Desktop()
        {
            return View();
        }
    }
}
