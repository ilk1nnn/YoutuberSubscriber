using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace YoutuberSubscriber.Entities
{
    public class Post
    {
        public Post(string content, Image postImage)
        {
            Content = content;
            PostImage = postImage;
        }

        public string Content { get; set; }
        public Image PostImage { get; set; }
    }
}
