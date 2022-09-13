using Microsoft.AspNetCore.Mvc;

namespace CorePortfolioProject.ViewComponents
{
    public class UIViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
