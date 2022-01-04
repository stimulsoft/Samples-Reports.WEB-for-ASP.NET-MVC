using System.Web;
using System.Web.Mvc;

namespace Adding_a_Font_to_the_Resource
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
