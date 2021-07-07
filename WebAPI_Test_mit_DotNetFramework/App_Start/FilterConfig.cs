using System.Web;
using System.Web.Mvc;

namespace WebAPI_Test_mit_DotNetFramework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
