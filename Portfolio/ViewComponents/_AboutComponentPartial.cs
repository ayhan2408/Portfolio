using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
