using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FlightMode.Controllers.api
{
    public class RoleController : ApiController
    {
        public String Get(string email)
        {
            using (FMAccountEntities entities = new FMAccountEntities())
            {
                string a = entities.GetRoleInfo(email).Single();
                return a;


            }
        }
    }
}
