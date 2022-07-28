using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudapplication.Startup))]
namespace crudapplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
