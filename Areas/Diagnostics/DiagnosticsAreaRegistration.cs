using System.Web.Mvc;

namespace FlightMode.Areas.Diagnostics
{
    public class DiagnosticsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Diagnostics";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Diagnostics_default",
                "Diagnostics/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}