using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightMode.Areas.TeleService.Controllers
{
    public class DefaultController : Controller
    {
        // GET: TeleService/Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewAppointment()
        {
            return View();
        }
        public ActionResult AllAppointments()
        {
            return View();
        }
        public ActionResult ViewAppointment()
        {
            return View();
        }

        public ActionResult EditAppointment()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}