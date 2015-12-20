using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI.Logic;

namespace WebAPI.Controllers
{
    public class LogOffController : ApiController
    {
        public  void Post()
        {
             HighLevelLogic.Logoff();

        }
    }
}
