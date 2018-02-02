using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginConsulta.Startup))]
namespace LoginConsulta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
