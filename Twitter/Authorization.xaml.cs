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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Twitter
{
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tbEmail.Text == "" || pbPassword.Password == "")
                {
                    Notification notification = new Notification(Brushes.OrangeRed, "Убедитесь что все поля заполнены");
                    notification.Notify();
                    return;
                }
                else
                {
                    NavigationService.Navigate(PageControl.Feed);
                }
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (tbEmail.Text == "" || pbPassword.Password == "")
                {
                    Notification notification = new Notification(Brushes.OrangeRed, "Убедитесь что все поля заполнены");
                    notification.Notify();
                    return;
                }
                else
                {
                    NavigationService.Navigate(PageControl.Feed);
                }
            }
        }
    }
}
