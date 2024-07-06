using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
