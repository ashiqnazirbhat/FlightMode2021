using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    [RoutePrefix("api/Roles")]
    public class RolesController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult All()
        {
            FMDataAccess entities = new FMDataAccess();
            List<Role> res = entities.Roles.ToList();
            return Ok(res);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(string id)
        {
            FMDataAccess entities = new FMDataAccess();

            var entity = entities.Roles.Find(id);

            if (entity != null)
            {
                return Ok(entity);
            }
            else
            {
                return NotFound();
            }
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