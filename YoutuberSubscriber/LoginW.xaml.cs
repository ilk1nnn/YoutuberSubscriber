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
    /// Interaction logic for LoginW.xaml
    /// </summary>
    public partial class LoginW : Window
    {
        public LoginW()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void loginbtn_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            foreach (var item in DataBase.subscribers)
            {
                if (item.Username == usernametxtb.Text)
                {
                    var subscriber = new SubscriberW();
                    subscriber.Show();
                }
            }
        }
    }
}
