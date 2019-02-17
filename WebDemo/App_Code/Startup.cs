using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YsDemo.Startup))]
namespace YsDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
