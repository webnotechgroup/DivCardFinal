using Microsoft.AspNetCore.Mvc;


namespace DivCardFinal.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_LatestArticles");
        }
    }
}
