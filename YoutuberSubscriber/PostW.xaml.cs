using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Image = System.Drawing.Image;
using YoutuberSubscriber.Database;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Drawing.Imaging;

namespace YoutuberSubscriber
{
    /// <summary>
    /// Interaction logic for PostW.xaml
    /// </summary>
    /// 
  



    public partial class PostW : Window
    {


        //public static BitmapImage ToWpfImage(this System.Drawing.Image img)
        //{
        //    MemoryStream ms = new MemoryStream();  // no using here! BitmapImage will dispose the stream after loading
        //    img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

        //    BitmapImage ix = new BitmapImage();
        //    ix.BeginInit();
        //    ix.CacheOption = BitmapCacheOption.OnLoad;
        //    ix.StreamSource = ms;
        //    ix.EndInit();
        //    return ix;
        //}

        public PostW()
        {
            InitializeComponent();

          

            foreach (var p in DataBase.posts)
            {

                var post = new PostUC();
                post.titlelbl.Content = p.Content.ToString();

                




                
                



                allpostsstackpanel.Children.Add(post);
            }


        }
    }
}
