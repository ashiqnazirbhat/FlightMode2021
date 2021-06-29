using FlightMode.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
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
        // PUT: api/Role/5
        [Authorize]
        public void Put(string Role)
        {
            using (FMAccountEntities entities = new FMAccountEntities())
            {
                ApplicationDbContext context = new ApplicationDbContext();
                var entity = entities.Users.FirstOrDefault(u => u.Email == User.Identity.Name);
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                IdentityResult result = UserManager.AddToRole(entity.Id, Role);
            }
        }
    }    
}
