using Microsoft.AspNetCore.Mvc;
//using MyPortfolio1.DAL.Context;

namespace MyPortfolio1.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        //MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            //var values = context.Experiences.ToList();
            return View();
        }
    }
}
