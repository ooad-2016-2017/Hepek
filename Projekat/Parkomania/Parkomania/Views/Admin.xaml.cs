﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Parkomania
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Admin : Page
    {
        List<Model.Admin> admins;
        List<Model.User> korsinici;
        List<Model.Parking> parkings;
        List<Model.Message> poruke;
        public Admin()
        {
            korsinici = ViewModel.System.users;
            admins = ViewModel.System.admins;
            parkings = ViewModel.System.parkings;
            poruke = ViewModel.System.Inbox;
            users = new ObservableCollection<string>();
            admini = new ObservableCollection<string>();
            messages = new ObservableCollection<string>();
            foreach (Model.Message m in poruke)
            {
                messages.Add(m.text);
            }
            foreach (Model.Parking p in parkings)
            {
                parkinzi.Add(p.Name);
            }
            foreach (Model.User u in korsinici)
            {
                users.Add(u.Firstname() + " " + u.Lastname());
            }
            foreach (Model.Admin a in admins)
            {
                admini.Add(a.Firstname() + " " + a.Lastname());
            }
            this.InitializeComponent();
            DataContext = new ViewModel.System();
            NavigationCacheMode = NavigationCacheMode.Required;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = (ViewModel.System)e.Parameter;
        }
        public ObservableCollection<string> admini;
        public ObservableCollection<string> users;
        public ObservableCollection<string> parkinzi;
        public ObservableCollection<string> messages;
    }
}
