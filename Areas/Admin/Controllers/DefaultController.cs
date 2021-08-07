using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightMode.Areas.Admin.Controllers
{
    [Authorize]
    public class DefaultController : Controller
    {
        // GET: Admin/Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddSpeciality()
        {
            return View();
        }
        public ActionResult AllSpeciality()
        {
            return View();
        }
        public ActionResult AddPackage()
        {
            return View();
        }
        public ActionResult AllPackage()
        {
            return View();
        }
        public ActionResult EditPackage()
        {
            return View();
        }
        public ActionResult AddItem()
        {
            return View();
        }
        public ActionResult AllItem()
        {
            return View();
        }
        public ActionResult EditItem()
        {
            return View();
        }
        public ActionResult AddTempReport()
        {
            return View();
        }
        public ActionResult AllTempReports()
        {
            return View();
        }
        public ActionResult AddTempTests()
        {
            return View();
        }
        public ActionResult ReportPrintPreview()
        {
            return View();
        }
        public ActionResult ReportPrint()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}