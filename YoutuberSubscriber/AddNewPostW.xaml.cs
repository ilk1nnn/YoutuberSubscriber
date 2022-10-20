using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using YoutuberSubscriber.Database;
using YoutuberSubscriber.Entities;

namespace YoutuberSubscriber
{
    /// <summary>
    /// Interaction logic for AddNewPostW.xaml
    /// </summary>
    public partial class AddNewPostW : Window
    {
        public AddNewPostW()
        {
            InitializeComponent();
        }

        public string Filename { get; set; }

        private Bitmap Photo;


        private static BitmapImage BitmapToSource(Bitmap src)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            src.Save(ms, ImageFormat.Jpeg);

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            ms.Seek(0, System.IO.SeekOrigin.Begin);
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }

        private void loadimgbtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true };
            bool? response = openFileDialog.ShowDialog();
            if (response == true)
            {
                string[] files = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFullPath(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri(filename);
                    logo.EndInit();
                    Photo = new Bitmap(filename);
                    postimg.Source = BitmapToSource(new Bitmap(Photo));

                    var path = filename.Split('\\');
                    Filename = path[path.Length - 1];
                }
            }
        }

        private void postbtn_Click(object sender, RoutedEventArgs e)
        {
            Post post = new Post(titletxtb.Text, Photo);
            DataBase.youtuber.Posts.Add(post);
            //foreach (var sub in DataBase.subscribers)
            //{
            //    sub.Notifications.Add(new Notification(DataBase.youtuber, $"{DataBase.youtuber.Username} posted ({titletxtb.Text}) at {DateTime.Now.ToString()}"));
            //}
            DataBase.notifications.Add(new Notification(DataBase.youtuber, $"{DataBase.youtuber.Username} posted ({titletxtb.Text}) at {DateTime.Now.ToString()}"));
            MessageBox.Show($"{DataBase.youtuber.Username}, Post Added Successfully!");
        }
    }
}
