using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Revealer
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            // Call the broadcastMessage method to update clients.
            //Clients.All.broadcastMessage(message);
            Clients.Others.broadcastMessage(message);
        }
    }
}