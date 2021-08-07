using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class TestController : ApiController
    {
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            FMDataAccess entities = new FMDataAccess();
            List<TempTest> res = entities.TempTests.ToList();
            return Ok(res);
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            FMDataAccess entities = new FMDataAccess();
            List<TempTest> res = entities.TempTests.Where(t => t.reportid == id).ToList();
            return Ok(res);
        }
        [HttpPost]
        // POST api/<controller>
        public IHttpActionResult Post([FromBody] TempTest tt)
        {
            try
            {
                using (FMDataAccess entities = new FMDataAccess())
                {

                    entities.TempTests.Add(tt);
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