using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Logic;
using WebAPI.Models;
using WebAPI.Models.DBContextClasses;
using WebAPI.TestClass;
using WebAPI.Validation;

namespace WebAPI.Controllers
{
  
    public class UsersController : ApiController
    {
        private Interface1 _test;

        public UsersController(Interface1 test)
        {
            _test = test;
        }



        // GET api/values
        public IEnumerable<string> Get()
        {

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            DBContext udb = new DBContext();
            Users u = new Users();
            //u.Username = "sds";
            //u.Password = "asd";
            //udb.Users.Add(u);
            //udb.SaveChanges();
            var result = udb.Users.ToList();
        
            return _test.getName();
        }

        // POST api/values
        public async Task<String> Post([FromBody]Users users)
        {
            var userExists = await ValidateUsers.ValidateUsername(users);
            if (userExists)
                return null;
           return await HighLevelLogic.AddUser(users);    

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
