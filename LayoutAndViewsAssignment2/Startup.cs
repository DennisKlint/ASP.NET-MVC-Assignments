using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LayoutAndViewsAssignment2.Startup))]
namespace LayoutAndViewsAssignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
