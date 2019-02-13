using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllFacultyInSinglePlatformWeb.Startup))]
namespace AllFacultyInSinglePlatformWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
