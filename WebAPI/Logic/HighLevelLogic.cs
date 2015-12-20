using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebAPI.Models;
using WebAPI.Models.DBContextClasses;

namespace WebAPI.Logic
{
    public class HighLevelLogic
    {
        public static async Task<string> AddUser(Users users) {
            DBContext db = new DBContext();
            UserLogs log = new UserLogs();
            log.Status = 1;
            log.LoginTime = DateTime.Now;
            users.userlogs.Add(log);
            db.Users.Add(users);
           
           await db.SaveChangesAsync().ConfigureAwait(false);
           return users.userlogs.Where(p => p.UserId == users.UserId).Where(p => p.Status == 1).FirstOrDefault().DeviceId.ToString();
            
        }

        public static async void AddAdderess( Addresses address) {
            DBContext db = new DBContext();
            Guid deviceId = new Guid(HttpContext.Current.Session["deviceId"].ToString());
            var userlog= await db.UserLogs.Where(p => p.DeviceId == deviceId).Where(p => p.Status == 1).FirstOrDefaultAsync().ConfigureAwait(false);
            if (userlog == null)
                return;
            var users=await db.Users.Where(p => p.UserId == userlog.UserId).FirstOrDefaultAsync().ConfigureAwait(false);
            users.addresses.contact = address.contact;
            users.addresses.location = address.location;
            db.Users.AddOrUpdate(users);
            await db.SaveChangesAsync().ConfigureAwait(false);


        }


        public static async void Logoff() {
            DBContext db = new DBContext();
            Guid deviceId = new Guid(HttpContext.Current.Session["deviceId"].ToString());
            var userlog = await db.UserLogs.Where(p => p.DeviceId == deviceId).Where(p => p.Status == 1).FirstOrDefaultAsync().ConfigureAwait(false);
            userlog.Status = 0;
            db.UserLogs.AddOrUpdate(userlog);
            await db.SaveChangesAsync().ConfigureAwait(false);

        }

        public static async Task<string> Login(Users user) {
            DBContext db = new DBContext();
          var users=await db.Users.Where(p => p.Username == user.Username).Where(p=>p.Password==user.Password).FirstOrDefaultAsync().ConfigureAwait(false);
            if (users == null)
                return null;
            UserLogs log = new UserLogs();
            log.Status = 1;
            log.LoginTime = DateTime.Now;
            users.userlogs.Add(log);
            db.Users.AddOrUpdate(users);
            await db.SaveChangesAsync().ConfigureAwait(false);
            return log.DeviceId.ToString();
        }

        public static async void AddRoles(Roles roles) {
            DBContext db = new DBContext();
            Guid deviceId = new Guid(HttpContext.Current.Session["deviceId"].ToString());
            var userlog = await db.UserLogs.Where(p => p.DeviceId == deviceId).Where(p => p.Status == 1).FirstOrDefaultAsync().ConfigureAwait(false);
            var users = await db.Users.Where(p => p.UserId == userlog.UserId).FirstOrDefaultAsync().ConfigureAwait(false);
            UserRoles userroles = new UserRoles();
            userroles.roles = roles;
            userroles.users = users;
            db.UserRoles.AddOrUpdate(userroles); 
            await db.SaveChangesAsync().ConfigureAwait(false);
        }



    }
}