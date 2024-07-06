using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.ViewComponents
{
    public class _InformationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
