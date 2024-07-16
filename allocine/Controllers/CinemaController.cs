using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class CinemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
