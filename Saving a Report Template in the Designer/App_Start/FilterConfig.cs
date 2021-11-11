using System.Web;
using System.Web.Mvc;

namespace Saving_a_Report_Template_in_the_Designer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
