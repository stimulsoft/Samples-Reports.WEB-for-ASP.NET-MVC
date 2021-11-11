using System.Web;
using System.Web.Mvc;

namespace Using_Business_Objects_in_the_Report
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
