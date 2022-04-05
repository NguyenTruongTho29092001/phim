using System.Web;
using System.Web.Mvc;

namespace NguyenTruongTho_1911066382_Tuan6
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
