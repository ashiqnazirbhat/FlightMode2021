using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class UserIdController : ApiController
    {
        // GET api/<controller>/5
        public string Get(string id)
        {
            using (FMDataAccess entities = new FMDataAccess())
            {
                string a = entities.GetID(id).Single();
                return a;
            }
        }
    }
}