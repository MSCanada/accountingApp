using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class UserRoles
    {
        public UserRoles() {
            roles = new Roles();
            users = new Users();
        }
            public virtual Guid UserRolesId { get; set; }

            public Guid UserId { get; set; }
            public Guid RolesId { get; set; }
           
            public  Users users { get; set; }
            public  Roles roles { get; set; }
        
    }
}