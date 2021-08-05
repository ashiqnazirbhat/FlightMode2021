using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class SpecialitiesController : ApiController
    {
        [HttpGet]
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            FMDataAccess entities = new FMDataAccess();
            List<Speciality> res = entities.Specialities.ToList();
            return Ok(res);
        }
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        // POST api/<controller>
        public IHttpActionResult Post([FromBody] Speciality Sp)
        {
            try
            {
                using (FMDataAccess entities = new FMDataAccess())
                {

                    entities.Specialities.Add(Sp);
                    entities.SaveChanges();
                    return Ok("Details Saved");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}