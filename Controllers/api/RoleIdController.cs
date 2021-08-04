using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class RoleIdController : ApiController
    {
        public IHttpActionResult Get(string id)
        {
            try
            {
                FMDataAccess entities = new FMDataAccess();
                var a = entities.GetRoleInfo(id).DefaultIfEmpty().Single();
                if (a != null)
                {
                    return Ok(a);
                }
                else
                {
                    return Ok("No Such User Exists");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
