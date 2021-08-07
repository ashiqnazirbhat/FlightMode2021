using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;



namespace FlightMode.Controllers.api
{
    public class PackageController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            FMDataAccess entities = new FMDataAccess();
            List<test_package> res = entities.test_package.ToList();
            return Ok(res);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public IHttpActionResult Post([FromBody] test_package tp)
        {
            try
            {
                using (FMDataAccess entities = new FMDataAccess())
                {

                    entities.test_package.Add(tp);
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