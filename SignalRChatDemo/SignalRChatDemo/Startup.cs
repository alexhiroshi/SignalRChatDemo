using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using SignalRChatDemo.Models;

[assembly: OwinStartupAttribute(typeof(SignalRChatDemo.Startup))]
namespace SignalRChatDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
