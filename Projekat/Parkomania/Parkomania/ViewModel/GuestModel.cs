using Parkomania.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Parkomania.ViewModel
{
    public class GuestModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public System Parent { get; set; }
        public ICommand exit { get; set; }
        public ICommand findme { get; set; }

        private string _search;
        public string searchparkingguest
        {
            get { return _search; }
            set
            {
                _search = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(searchparkingguest)));
                }
            }
        }
        public GuestModel()
        {

        }
        public GuestModel(System p)
        {
            this.Parent = p;
            exit = new RelayCommand<object>(closeGuestForm, Check);
            findme = new RelayCommand<object>(findMeGps, Check);
        }

        public void findMeGps(object parametar)
        {

        }
        public bool Check(object parametar)
        {
            return true;
        }
        public void closeGuestForm(object parametar)
        {
            Parent.NavigationService.GoBack();
        }
    }

}

