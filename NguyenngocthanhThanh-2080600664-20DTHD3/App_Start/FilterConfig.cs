using System.Web;
using System.Web.Mvc;

namespace NguyenngocthanhThanh_2080600664_20DTHD3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
