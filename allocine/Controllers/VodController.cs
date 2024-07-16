using Microsoft.AspNetCore.Mvc;

namespace allocine.Controllers
{
    public class VodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
