using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    [RoutePrefix("api/Appointment")]
    public class AppointmentController : ApiController
    {
        [HttpPost]
        // POST api/<controller>
        public IHttpActionResult Insert([FromBody] Appointment appoint)
        {
            try
            {
                using (FMDataAccess entities = new FMDataAccess())
                {

                    entities.Appointments.Add(appoint);
                    entities.SaveChanges();
                    return Ok("Appointment Details Saved");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}