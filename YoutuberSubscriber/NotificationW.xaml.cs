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
    /// Interaction logic for NotificationW.xaml
    /// </summary>
    public partial class NotificationW : Window
    {
        public NotificationW()
        {
            InitializeComponent();

            foreach (var item in DataBase.notifications)
            {
                var notification = item.Title;
                notificationlistbox.Items.Add(notification);
            }

        }
    }
}
