using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Twitter
{
    public class Notification
    {
        NotificationUI notificationUI { get; set; }
        private SolidColorBrush Background { get; set; }
        public string Text { get; set; }
        public Notification(SolidColorBrush background, string text)
        {
            Background = background;
            Text = text;
        }
        public Notification(SolidColorBrush background)
        {
            Background = background;
        }

        public void Notify()
        {
            if (notificationUI == null)
                notificationUI = new NotificationUI();
            notificationUI.notificationBorder.Background = Background;
            notificationUI.tbMessage.Text = Text;
            if (MainWindow.NotificationGridArea.Children.Count <= 5) 
            {
                MainWindow.NotificationGridArea.Children.Add(notificationUI);
                notificationUI.BeginAnimation(Border.OpacityProperty, new DoubleAnimation(0, TimeSpan.FromSeconds(3)));
            }
            else
            {
                MainWindow.NotificationGridArea.Children.Clear();
            }
        }
    }
}
