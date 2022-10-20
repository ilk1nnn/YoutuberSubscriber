using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutuberSubscriber.Entities;

namespace YoutuberSubscriber.Database
{
    static public class DataBase
    {
        static public List<Post> posts = new List<Post>();
        static public List<Notification> notifications = new List<Notification>();
        static public Youtuber youtuber = new Youtuber("john123", posts);



        static public List<Subscriber> subscribers = new List<Subscriber>()
        {
            new Subscriber("subscriber1",notifications),
            new Subscriber("subscriber2",notifications),
            new Subscriber("subscriber3",notifications)
        };
    
    }
}
