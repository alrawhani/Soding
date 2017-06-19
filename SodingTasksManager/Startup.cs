using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SodingTasksManager.Startup))]
namespace SodingTasksManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
