using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
