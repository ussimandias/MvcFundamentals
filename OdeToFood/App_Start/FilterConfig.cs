using System.Web;
using System.Web.Mvc;
using OdeToFood.Infrastructure;

namespace OdeToFood
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogAttribute());
        }
    }
}
