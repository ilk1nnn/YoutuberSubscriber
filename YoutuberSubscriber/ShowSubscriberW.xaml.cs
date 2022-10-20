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
using YoutuberSubscriber.Database;

namespace YoutuberSubscriber
{
    /// <summary>
    /// Interaction logic for ShowSubscriberW.xaml
    /// </summary>
    public partial class ShowSubscriberW : Window
    {
        public ShowSubscriberW()
        {
            InitializeComponent();



            foreach (var item in DataBase.subscribers)
            {
                var username = item.Username;
                subscriberlistbox.Items.Add(username);
            }
        }
    }
}
