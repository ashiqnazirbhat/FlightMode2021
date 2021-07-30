using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightMode.Areas.Patient.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Patient/Default
        public ActionResult Index()
        {
            return View();
        }
        //Communication
        public ActionResult NewMessages()
        {
            return View();
        }
        public ActionResult ArchievedMessages()
        {
            return View();
        }
        //Appointments
        public ActionResult NewAppointment()
        {
            return View();
        }
        public ActionResult FollowUp()
        {
            return View();
        }

        //Reports 
        public ActionResult RequestReports()
        {
            return View();
        }
        public ActionResult UpdatedReports()
        {
            return View();
        }
        public ActionResult ArchievedReports()
        {
            return View();
        }
        public ActionResult Todo()
        {
            return View();
        }
        public ActionResult UserProfile()
        {
            return View();
        }
        public ActionResult HealthFeed()
        {
            return View();
        }
        public ActionResult Feedback()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }

        //Updations
        public ActionResult EditPersonalInfo()
        {
            return View();
        }
        
        public ActionResult EditAddressInfo()
        {
            return View();
        }
        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}