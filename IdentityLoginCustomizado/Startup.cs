using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityLoginCustomizado.Startup))]
namespace IdentityLoginCustomizado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
