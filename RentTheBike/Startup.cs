using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentTheBike.Startup))]
namespace RentTheBike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
