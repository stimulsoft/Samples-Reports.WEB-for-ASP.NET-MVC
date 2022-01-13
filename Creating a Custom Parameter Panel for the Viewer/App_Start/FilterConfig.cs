using System.Web;
using System.Web.Mvc;

namespace Creating_a_Custom_Parameter_Panel_for_the_Viewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
