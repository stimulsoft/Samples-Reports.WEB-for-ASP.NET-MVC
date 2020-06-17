using System.Web;
using System.Web.Mvc;

namespace Connect_to_Data_from_the_Code
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
