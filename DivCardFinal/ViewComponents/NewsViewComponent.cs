using Microsoft.AspNetCore.Mvc;

namespace DivCardFinal.ViewComponents
{
    public class NewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("_News");
        }
    }

}
