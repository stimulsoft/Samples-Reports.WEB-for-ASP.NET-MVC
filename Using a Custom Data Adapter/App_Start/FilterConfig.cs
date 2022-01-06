using System.Web;
using System.Web.Mvc;

namespace Using_a_Custom_Data_Adapter
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
