using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PerJson.Startup))]
namespace PerJson
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
