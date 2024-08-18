using Microsoft.AspNetCore.Mvc;

namespace TechVerse_backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
