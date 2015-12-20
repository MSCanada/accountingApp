using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WebAPI.Models;
using System.Data.Entity;
using WebAPI.Models.DBContextClasses;

namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Addresses GetAddress(string userId)
        {
            DBContext db = new DBContext();
            Guid usId = new Guid(userId);
            var users = db.Users.Include(p => p.userroles).Include(p => p.userlogs).Where(p => p.UserId == usId).FirstOrDefault();
            return db.Addresses.Where(p => p.AddressId == users.AddressId).FirstOrDefault();
        }

        public Addresses GetAddressRest(string userId)
        {
            DBContext db = new DBContext();
            Guid usId = new Guid(userId);
            var users = db.Users.Include(p => p.userroles).Include(p => p.userlogs).Where(p => p.UserId == usId).FirstOrDefault();
            return db.Addresses.Where(p => p.AddressId == users.AddressId).FirstOrDefault();

        }

        public Roles GetRoles(string userId)
        {
           DBContext db = new DBContext();
           Guid usId = new Guid(userId);
            var users = db.Users.Include(p => p.userroles).Include(p=>p.userlogs).Where(p => p.UserId == usId).FirstOrDefault();
           var userroles=db.UserRoles.Include(p=>p.roles).Where(p => p.UserId == users.UserId).FirstOrDefault();
            if (userroles == null)
                return null;
            return  db.Roles.Where(p => p.RolesId == userroles.RolesId).FirstOrDefault();
           
        }

        public Roles GetRolesRest(string userId)
        {
            DBContext db = new DBContext();
            Guid usId = new Guid(userId);
            var users = db.Users.Include(p => p.userroles).Include(p => p.userlogs).Where(p => p.UserId == usId).FirstOrDefault();
            var userroles = db.UserRoles.Include(p => p.roles).Where(p => p.UserId == users.UserId).FirstOrDefault();
            if (userroles == null)
                return null;
            return db.Roles.Where(p => p.RolesId == userroles.RolesId).FirstOrDefault();

        }

        public Users GetUser(string username,string password)
        {
            DBContext db = new DBContext();
           return  db.Users.Where(p => p.Username == username).Where(p => p.Password==password).FirstOrDefault();

        }

        public Users GetUserRest(string username, string password)
        {

            DBContext db = new DBContext();
            return db.Users.Where(p => p.Username == username).Where(p => p.Password == password).FirstOrDefault();

        }
    }
}
