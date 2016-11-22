using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;
using System;

namespace SignalRTeach
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR<TrackerConnection>("/tracker");
        }
    }
}