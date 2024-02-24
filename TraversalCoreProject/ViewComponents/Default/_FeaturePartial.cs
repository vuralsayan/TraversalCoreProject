using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeaturesDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManager.TGetList().Where(item => item.Status).Take(5).ToList();
            return View(values);
        }
    }
}
