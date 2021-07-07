using System;
using SignalRCoreContainerTest.Lib;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRCoreContainerTest.Server
{
    #region ClockHub
    public class ClockHub : Hub<IClock>
    {
        public async Task SendTimeToClients(DateTime dateTime)
        {
            await Clients.All.ShowTime(dateTime);
        }
    }
    #endregion
}