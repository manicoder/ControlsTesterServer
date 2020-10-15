using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlsTesterServer.Hubs
{
    public class SendMessageHub : Hub
    {
        public async Task SendMessageFromServer(string values)
        {
            await Clients.Others.SendAsync("ReceiveNewMessage", values);
        }

        public async Task MyClassSendMessageFromServer(MyClass values)
        {
            //await Clients.Others.SendAsync("MyClassReceiveNewMessage", values);
            await Clients.All.SendAsync("MyClassReceiveNewMessage", values);
        }
    }
}
