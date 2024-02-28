using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _ProfileInformationPartial : ViewComponent
    {
        public readonly UserManager<AppUser> _userManager;

        public _ProfileInformationPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            ViewBag.memberName = values.Name + " " + values.Surname;
            ViewBag.phoneNumber = values.PhoneNumber;
            ViewBag.mail = values.Email;    
            return View();
        }
    }
}

