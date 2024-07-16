using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class TvActuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
