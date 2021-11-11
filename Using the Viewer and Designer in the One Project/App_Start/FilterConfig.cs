using System.Web;
using System.Web.Mvc;

namespace Using_the_Viewer_and_Designer_in_the_One_Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
