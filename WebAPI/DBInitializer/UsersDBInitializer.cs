using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAPI.Models;
using WebAPI.Models.DBContextClasses;

namespace WebAPI.DBInitializer
{
    public class UsersDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Users.Add(new Users { Username = "msuhail", Password="cricket" }); 
            base.Seed(context); }
    }

}