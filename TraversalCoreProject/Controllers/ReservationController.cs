using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }

        public IActionResult MyActiveReservations()
        {
            return View();
        }   

        public IActionResult MyOldReservations()
        {
            return View();  
        }
    }
}
