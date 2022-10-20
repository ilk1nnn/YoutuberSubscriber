using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace YoutuberSubscriber.Entities
{
    public class Notification
    {
        public Notification(Youtuber youtuber, string title)
        {
            Youtuber = youtuber;
            Title = title;
        }

        public Youtuber Youtuber { get; set; }
        public string Title { get; set; }
    }
}
