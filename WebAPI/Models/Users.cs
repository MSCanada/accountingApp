using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Users
    {
        public Users() {
            userlogs = new List<UserLogs>();
            addresses = new Addresses();
            userroles = new List<UserRoles>();
        }
        public virtual Guid UserId { get; set; }
        public virtual String Username { get; set; }

        public virtual String Password { get; set; }

        public  ICollection<UserLogs> userlogs { get; set; }

        public virtual Guid? AddressId { get; set; }

        public  Addresses addresses { get; set; }

        public  ICollection<UserRoles> userroles { get; set; }

    }
}