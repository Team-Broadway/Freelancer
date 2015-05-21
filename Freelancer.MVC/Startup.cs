using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Freelancer.MVC.Startup))]
namespace Freelancer.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
