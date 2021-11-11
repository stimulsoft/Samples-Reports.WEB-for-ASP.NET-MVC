using System.Web;
using System.Web.Mvc;

namespace Adding_a_Custom_Function_to_the_Designer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
