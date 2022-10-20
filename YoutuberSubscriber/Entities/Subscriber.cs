using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberSubscriber.Entities
{
    public class Subscriber
    {
        public Subscriber(string username, List<Notification> notifications)
        {
            Username = username;
            Notifications = notifications;
        }

        public string Username { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
