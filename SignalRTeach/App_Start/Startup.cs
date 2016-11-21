using Owin;

namespace SignalRTeach
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<EchoConnection>(path: "/realtime/echo");
        }
    }
}