using System.Web;
using System.Web.Mvc;

namespace ThirteenDaysAWeek.Mvc4CustomErrorPage.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}