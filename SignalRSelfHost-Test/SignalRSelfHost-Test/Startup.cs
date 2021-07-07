using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;

namespace SignalRSelfHost_Test
{
    /*
    Startup, the class containing the configuration for the SignalR server(the only configuration this tutorial uses 
    is the call to UseCors), and the call to MapSignalR, which creates routes for any Hub objects in the project.
    */
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var hubConfiguration = new HubConfiguration
            {
                //EnableCrossDomain = true,
                EnableDetailedErrors = true
            };
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR(hubConfiguration);
            //app.MapSignalR("/Hub", new HubConfiguration());
        }
    }
}