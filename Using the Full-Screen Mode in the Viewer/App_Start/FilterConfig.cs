using System.Web;
using System.Web.Mvc;

namespace Using_the_Full_Screen_Mode_in_the_Viewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
