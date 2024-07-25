using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
