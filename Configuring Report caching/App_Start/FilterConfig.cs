using System.Web;
using System.Web.Mvc;

namespace Configuring_Report_caching
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
