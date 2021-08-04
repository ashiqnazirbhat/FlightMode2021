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
        [HttpGet]
        public IHttpActionResult AllAppointments()
        {
            FMDataAccess entities = new FMDataAccess();
            List<Appointment> res = entities.Appointments.ToList();
            return Ok(res);
        }

        [HttpGet]
        [Route("AppId/{id}")]
        public IHttpActionResult AppId(int id)
        {
            FMDataAccess entities = new FMDataAccess();

            var entity = entities.Appointments.Find(id);

            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return NotFound();
            }
        }

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