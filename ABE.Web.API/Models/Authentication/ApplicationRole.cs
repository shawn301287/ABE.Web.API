using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABE.Web.API.Models.Authentication
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        //public ApplicationRole(string roleName) : base(roleName)
        //{
        //    this.Name = roleName;
        //}

        public string Description { get; set; }
    }
}
