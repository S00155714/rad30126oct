using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment_attempt_2.Startup))]
namespace assignment_attempt_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
