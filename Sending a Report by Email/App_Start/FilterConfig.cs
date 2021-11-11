using System.Web;
using System.Web.Mvc;

namespace Sending_a_Report_by_Email
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
