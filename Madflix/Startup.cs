using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Madflix.Startup))]
namespace Madflix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
