using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Image2 = System.Drawing.Image;
namespace YoutuberSubscriber.Entities
{
    public class Post
    {
        public Post(string content,Image2 postImage)
        {
            Content = content;
            PostImage = postImage;
        }

        public string Content { get; set; }
        public Image2 PostImage { get; set; }
    }
}
