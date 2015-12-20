using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPI.Filters
{
    public class ActionFilter : ActionFilterAttribute

    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var output = actionContext;
            IEnumerable<string> value;
            actionContext.Request.Headers.TryGetValues("deviceId", out value);
            if (value == null)
                return;
            var deviceId=value.ToList()[0];
            HttpContext.Current.Session["deviceId"] = deviceId;
            
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            var output = actionExecutedContext;
           
        }
     

       

    }
}