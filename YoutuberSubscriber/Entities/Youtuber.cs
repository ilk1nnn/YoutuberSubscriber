using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutuberSubscriber.Entities
{
    public class Youtuber
    {
        public Youtuber(string username, List<Post> posts)
        {
            Username = username;
            Posts = posts;
        }

        public string Username { get; set; }
        public List<Post> Posts { get; set; }
    }
}
