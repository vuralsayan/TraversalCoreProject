using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        // Dependency Injection kullanılabilir
        //private readonly DestinationManager _destinationManager;
        //private readonly ReservationManager _reservationManager;

        //public ReservationController(DestinationManager destinationManager, ReservationManager reservationManager)
        //{
        //    _destinationManager = destinationManager;
        //    _reservationManager = reservationManager;   
        //}

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        ReservationManager reservationManager = new ReservationManager(new EfReservationDal());

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserID = 1;
            p.Status = "Onay Bekleniyor";
            reservationManager.TAdd(p);
            return RedirectToAction("MyActiveReservations");
        }

        public async Task<IActionResult> MyActiveReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            var reservationList = reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(reservationList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            var reservationList = reservationManager.GetListWithReservationByWaitAprroval(values.Id);
            return View(reservationList);
        }

        public async Task<IActionResult> MyOldReservations()
        {
            var values = await _userManager.FindByNameAsync(User.Identity?.Name);
            var reservationList = reservationManager.GetListWithReservationByPrevious(values.Id);
            if (reservationList.Count == 0)
            {
                ViewBag.text = "Hiç eski rezervasyonunuz bulunmamaktadır";
            }
            return View(reservationList);
        }
    }
}
