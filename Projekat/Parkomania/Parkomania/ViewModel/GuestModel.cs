using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Parkomania.ViewModel
{
    class GuestModel
    {
        public List<Model.Guest> guests;
        public ICommand LoginGosta { get; set; }
        public GuestModel()
        {
            guests = new List<Model.Guest>();

            LoginGosta = new RelayCommand<object>(openGuestForm, check);
        }
       public void openGuestForm(object parametar)
        {
            NavigationService.Navigate(typeof(GlavnaForma), new test(this));
        }
        public bool check(object parametar)
        {
            //provjeriti
            return true;
        }          
    }
}

