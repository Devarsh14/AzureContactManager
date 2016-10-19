using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureContactManager.Startup))]
namespace AzureContactManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
