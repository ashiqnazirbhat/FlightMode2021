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

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
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