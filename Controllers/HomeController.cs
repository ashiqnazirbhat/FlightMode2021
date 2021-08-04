using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FlightMode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
        public ActionResult Appointment()
        {
            return View();
        }
        public ActionResult Career()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Try()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult UpdateProfile()
        {
            return View();
        }

        public string CheckRole(string value)
        {
            ViewBag.StoreItem = value;

            return value;
            //Url.Action("Index", "Admin/default", null);

            //return View();
            
        }
    }
}
