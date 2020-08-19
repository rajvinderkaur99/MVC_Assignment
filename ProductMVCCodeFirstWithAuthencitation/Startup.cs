using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductMVCCodeFirstWithAuthencitation.Startup))]
namespace ProductMVCCodeFirstWithAuthencitation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
