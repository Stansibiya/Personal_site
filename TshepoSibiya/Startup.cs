using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TshepoSibiya.Startup))]
namespace TshepoSibiya
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
