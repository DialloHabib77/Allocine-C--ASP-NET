using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class StreamingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
