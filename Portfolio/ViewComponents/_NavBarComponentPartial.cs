﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio1.ViewComponents
{
    public class _NavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}