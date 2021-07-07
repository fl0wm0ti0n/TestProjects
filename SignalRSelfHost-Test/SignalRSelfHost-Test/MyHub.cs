using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRSelfHost_Test
{
    /*
    MyHub, the SignalR Hub class that the application will provide to clients.This class has a single 
    method, Send, that clients will call to broadcast a message to all other connected clients.
    */
    [HubName("MyHub")]
    public class MyHub : Hub
    {
        PersonModel person = new PersonModel()
        {
            FirstName = "Florian",
            LastName = "Gabriel",
            Number = 12424563
        };

        public override Task OnConnected()
        {
            var version = Context.QueryString["WPFClient"];
            if (version != "1.0")
            {
                Clients.Caller.notifyWrongVersion();
            }
            Console.WriteLine("Connection established: " + Context.ConnectionId);
            Clients.Client(Context.ConnectionId).cl_SendAsync("ReceiveConnID: " + Context.ConnectionId);
            Clients.Others.cl_SendAsync($"Client with ID {0} connected to the Chat", Context.ConnectionId);

            return base.OnConnected();
        }

        [HubMethodName("srv_SendAsync")]
        public async Task srv_SendAsync(string message)
        {
            Console.WriteLine(Context.ConnectionId + ":" + message);
            await Clients.All.cl_SendAsync(message);
        }

        [HubMethodName("srv_SendAsyncPerson")]
        public async Task srv_SendAsyncPerson()
        {
            await Clients.All.cl_SendAsyncPerson(person);
        }
    }
}