using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

using WebAPI.Logic;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class RolesController : ApiController
    {
        public  void Post(Roles roles)
        {
            HighLevelLogic.AddRoles(roles);

        }
    }
}
