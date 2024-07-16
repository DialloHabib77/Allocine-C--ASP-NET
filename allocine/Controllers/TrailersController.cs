using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class TrailersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
