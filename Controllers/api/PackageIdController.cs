using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class PackageIdController : ApiController
    {
        
        // GET api/<controller>/5
        public int Get(string id)
        {
            using (FMDataAccess entities = new FMDataAccess())
            {
                int a = (int)entities.PackageId(id).Single();
                return a;
            }
        }
    }
}