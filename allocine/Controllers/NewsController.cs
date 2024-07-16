using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
