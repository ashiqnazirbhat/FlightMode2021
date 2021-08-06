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
        public ActionResult Logout()
        {
            return View();
        }
    }
}