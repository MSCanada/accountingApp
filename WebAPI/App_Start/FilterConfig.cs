using System.Web;
using System.Web.Mvc;
using WebAPI.Filters;

namespace WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, System.Web.Http.Filters.HttpFilterCollection filters1)
        {
            filters.Add(new HandleErrorAttribute());
            filters1.Add(new ActionFilter());
        }
    }
}
