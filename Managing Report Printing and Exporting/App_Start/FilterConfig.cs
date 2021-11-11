using System.Web;
using System.Web.Mvc;

namespace Managing_Report_Printing_and_Exporting
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
