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

namespace YoutuberSubscriber
{
    /// <summary>
    /// Interaction logic for YoutuberW.xaml
    /// </summary>
    public partial class YoutuberW : Window
    {
        public YoutuberW()
        {
            InitializeComponent();
        }


        class Subscriber
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        List<Subscriber> subscribers = new List<Subscriber>
        {


            new Subscriber
            {
                Username = "admin1",
                Password ="admin1"
            },
            new Subscriber
            {
                Username = "admin2",
                Password="admin2"
            },
            new Subscriber
            {
                Username = "admin3",
                Password="admin3"
            },
            new Subscriber
            {
                Username="admin4",
                Password = "admin4"
            }

        };

        private void ShowSub(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
