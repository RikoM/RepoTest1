using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1.Startup))]
namespace WebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //this is only comment for check git push
            //update from github.com test
            //lagi
            ConfigureAuth(app);
        }
    }
}
