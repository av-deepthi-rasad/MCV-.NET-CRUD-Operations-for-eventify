using Microsoft.AspNetCore.Mvc;

namespace Eventify_web_api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
