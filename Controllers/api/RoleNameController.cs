using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class RoleNameController : ApiController
    {
        public string Get(string id)
        {
            using (FMDataAccess entities = new FMDataAccess())
            {
                string a = entities.RoleName(id).Single();
                return a;
            }
        }
    }
}
