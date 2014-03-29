using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace AngularR.Hubs
{
    public class Anghub : Hub
    {

        public void Send(string name)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name);
        }
        
    }
}