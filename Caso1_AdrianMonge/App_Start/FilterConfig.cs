using System.Web;
using System.Web.Mvc;

namespace Caso1_AdrianMonge
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
