﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_ErsteApp.Startup))]
namespace SignalR_ErsteApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
