using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LongListSelectorAdd
{
    public partial class MainPageWithCustomControl : PhoneApplicationPage
    {
        public MainPageWithCustomControl()
        {
            InitializeComponent();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Register<NotificationMessage>(this, msg =>
            {
                //if(msg.Notification.Equals("ListReposition"))
                //this.LLS.ScrollTo(this.LLS.ItemsSource[0]);
            });
            Messenger.Default.Send(new NotificationMessage("ViewLoaded"));
        }
    }
}