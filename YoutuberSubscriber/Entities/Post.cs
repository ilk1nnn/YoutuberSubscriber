using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace YoutuberSubscriber.Entities
{
    public class Post
    {
        public Post(string content, Bitmap postImage)
        {
            Content = content;
            PostImage = postImage;
        }

        public string Content { get; set; }
        public Bitmap PostImage { get; set; }
    }
}
