using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace SignalRTeach
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //var config = new ConnectionConfiguration() {
            //    EnableJSONP = true
            //};
            //app.MapSignalR<EchoConnection>(path: "/realtime/echo",configuration:config);
            app.Map(pathMatch: "/realtime/echo",
                configuration:
                map =>
                {
                    map.UseCors(CorsOptions.AllowAll);
                    map.RunSignalR<EchoConnection>();
                }
                );
        }
    }
}