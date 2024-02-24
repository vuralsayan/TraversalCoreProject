using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.TotalDestination = c.Destinations?.Count();
            ViewBag.Guides = c.Guides?.Count();
            ViewBag.Customer = "265";
            return View();
        }
    }
}
