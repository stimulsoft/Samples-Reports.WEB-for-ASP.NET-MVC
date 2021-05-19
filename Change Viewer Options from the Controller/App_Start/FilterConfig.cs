using System.Web;
using System.Web.Mvc;

namespace Change_Viewer_Options_from_the_Controller
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
