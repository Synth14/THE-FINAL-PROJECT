using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(THE_FINAL_PROJECT.Startup))]
namespace THE_FINAL_PROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
