using System.Web;
using System.Web.Mvc;
using GlobalizationAndLocalization.Filters;

namespace GlobalizationAndLocalization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //Global level
            filters.Add(new CustomExceptionFilter());
        }
    }
}
