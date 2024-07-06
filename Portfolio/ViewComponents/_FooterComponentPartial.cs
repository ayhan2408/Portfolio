using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
