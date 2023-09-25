using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class PageController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Skill()
        {
            return View();
        }

        public IActionResult Contact() 
        { 
            return View();
        }
    }
}
