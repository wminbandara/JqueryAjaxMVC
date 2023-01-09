using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryAjaxMVC.Startup))]
namespace JqueryAjaxMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
