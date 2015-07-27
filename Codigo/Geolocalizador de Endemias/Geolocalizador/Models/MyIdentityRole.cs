using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Geolocalizador.Models
{
    public class MyIdentityRole : IdentityRole
    {
        public MyIdentityRole()
        {

        }

        public MyIdentityRole(string roleName, string description) :base(roleName)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }
}