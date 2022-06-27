using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FacadePattern.Solution
{
    public class NotificationService
    {
        public void send(string message,string target)
        {
            var server = new NotificationServer();
            var connection = server.connect("ip");
            var authToken = server.authenticate("appId", "key");
            server.send(authToken, new Message(message), target);
            connection.disconnect();
        }
    }
}
