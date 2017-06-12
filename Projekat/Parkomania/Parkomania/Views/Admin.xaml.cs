using System;
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
        List<Model.Account> koradmini;
        List<Model.Parking> parkings;
        List<Model.Message> poruke;
        public Admin()
        {
            koradmini = ViewModel.System.acc;
            parkings = ViewModel.System.parkings;
            poruke = ViewModel.System.Inbox;
            users = new ObservableCollection<string>();
            admini = new ObservableCollection<string>();
            messages = new ObservableCollection<string>();
            parkinzi = new ObservableCollection<string>();
           // foreach (Model.Message m in poruke)
           // {
           //     messages.Add(m.text);
           // }
            foreach (Model.Parking p in parkings)
            {
                parkinzi.Add(p.Name);
            }
            foreach (Model.Account u in koradmini)
            {
                if(u.Acctype().Equals("user"))
                    users.Add(u.Firstname() + " " + u.Lastname());
            }
            foreach (Model.Account a in koradmini)
            {
                if (a.Acctype().Equals("admin")) 
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
