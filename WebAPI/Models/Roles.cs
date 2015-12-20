using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Roles
    {
        public Roles() {
            userroles = new List<UserRoles>();
        }
        public virtual Guid RolesId { get; set; }
        public virtual String RoleName { get; set; }
        

        public  ICollection<UserRoles> userroles {get;set;} 
    }
}