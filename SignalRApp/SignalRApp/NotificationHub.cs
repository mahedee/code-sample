using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRApp
{
    
    [HubName("notification")]
    public class NotificationHub : Hub
    {
         public void PushNotification(string msg)
         {
             Clients.All.response(msg);
         }
    }
}