using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
