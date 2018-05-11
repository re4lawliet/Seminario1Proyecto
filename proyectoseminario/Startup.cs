using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyectoseminario.Startup))]
namespace proyectoseminario
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
