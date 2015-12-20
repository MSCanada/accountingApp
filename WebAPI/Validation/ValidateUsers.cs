using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebAPI.Models;
using WebAPI.Models.DBContextClasses;

namespace WebAPI.Validation
{
    public class ValidateUsers
    {
        public static async Task<Boolean> ValidateUsername(Users users) {
            if (users.Username == "" || users.Username == null || users.Password == "" || users.Password == null)
                return true;
            DBContext db = new DBContext();
            var userExist = await db.Users.Where(p => p.Username == users.Username).AnyAsync().ConfigureAwait(false);
            if (userExist)
                return true;
            else return false;
        }
    }
}