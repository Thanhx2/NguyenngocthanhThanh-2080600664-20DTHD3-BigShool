using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenngocthanhThanh_2080600664_20DTHD3.Startup))]
namespace NguyenngocthanhThanh_2080600664_20DTHD3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
