using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;
using System.Data.Entity;
using System.Web.Http.Description;


namespace FlightMode.Controllers.api
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        [ResponseType(typeof(User))]
        // GET api/<controller>
        public IHttpActionResult Get()
        {
            FMDataAccess entities = new FMDataAccess();
            List<User> res = entities.Users.ToList();
            return Ok(res);
        }

        // GET api/<controller>/5
        [ResponseType(typeof(User))]
        public IHttpActionResult Get(String id)
        {
            FMDataAccess entities = new FMDataAccess();
            var entity = entities.Users.Find(id);
            
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
        [Route("EditProfile")]
        [HttpPut]
        public IHttpActionResult EditProfile([FromBody] User user)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest("Not a valid model");
            try
            {
                using (FMDataAccess entities = new FMDataAccess())
                {

                    var entity = entities.Users.Where(u => u.UserName == user.UserName).FirstOrDefault<User>();

                    if (entity != null) {
                        entity.FName = user.FName;
                        entity.LName = user.LName;
                        entity.MName = user.MName;
                        entity.Gender = user.Gender;
                        entity.DateOfBirth = user.DateOfBirth;
                        entity.PhoneNumber = user.PhoneNumber;
                        entity.AltNumber = user.AltNumber;
                        entity.Status = user.Status;
                        entity.CreatedBy = user.CreatedBy;
                        entity.CreatedDate = user.CreatedDate;
                        entity.ModifiedBy = user.ModifiedBy;
                        entity.ModifiedDate = user.ModifiedDate;


                        entities.SaveChanges();

                        return Ok("Added");
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}