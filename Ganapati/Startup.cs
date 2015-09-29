using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ganapati.Startup))]
namespace Ganapati
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
