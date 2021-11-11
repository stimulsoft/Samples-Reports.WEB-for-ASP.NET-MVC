using System.Web;
using System.Web.Mvc;

namespace Exporting_and_Printing_a_Report_from_Code
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
