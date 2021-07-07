using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;

namespace SignalRSelfHost_Test
{
    /*
    Program, including the Main method defining the primary path of execution.In this method, a web application of type Startup is started at the specified URL (http://localhost:8080). 
    If security is required on the endpoint, SSL can be implemented. See How to: Configure a Port with an SSL Certificate for more information.
    */
    /// <summary>
    /// https://docs.microsoft.com/en-us/aspnet/signalr/overview/deployment/tutorial-signalr-self-host
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/library/system.net.httplistener.aspx 
            // for more information.

            string url = "http://localhost:8080";
            //WebApp.Start<Startup>(url);
            using (WebApp.Start(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }
}