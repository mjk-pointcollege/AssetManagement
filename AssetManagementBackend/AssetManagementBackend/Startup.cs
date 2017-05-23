using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetManagementBackend.Startup))]
namespace AssetManagementBackend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
