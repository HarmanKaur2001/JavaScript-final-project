using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finalexam.Startup))]
namespace Finalexam
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
