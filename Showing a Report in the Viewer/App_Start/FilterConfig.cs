using System.Web;
using System.Web.Mvc;

namespace Showing_a_Report_in_the_Viewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
