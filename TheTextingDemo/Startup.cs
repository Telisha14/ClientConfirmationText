using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheTextingDemo.Startup))]
namespace TheTextingDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
