using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSAppJenkins.Startup))]
namespace MSAppJenkins
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
