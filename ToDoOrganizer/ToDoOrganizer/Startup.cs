using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoOrganizer.Startup))]
namespace ToDoOrganizer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
