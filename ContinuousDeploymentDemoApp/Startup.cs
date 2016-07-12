using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContinuousDeploymentDemoApp.Startup))]
namespace ContinuousDeploymentDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
