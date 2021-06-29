using System.Web.Mvc;

namespace FlightMode.Areas.Physician
{
    public class PhysicianAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Physician";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Physician_default",
                "Physician/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}