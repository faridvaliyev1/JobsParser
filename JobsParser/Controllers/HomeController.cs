using Microsoft.AspNetCore.Mvc;

namespace JobsParser.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
