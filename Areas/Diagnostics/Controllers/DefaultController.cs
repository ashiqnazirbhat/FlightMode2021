using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightMode.Areas.Diagnostics.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Diagnostics/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}