using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightMode.Models;

namespace FlightMode.Controllers.api
{
    public class PackagesController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            FMDataAccess entities = new FMDataAccess();
            List<string> a = entities.PackageNames().ToList();
            return a;
        }
    }
}