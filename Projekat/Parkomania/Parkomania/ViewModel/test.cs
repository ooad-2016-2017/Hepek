using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.ViewModel
{
    class test : INotifyPropertyChanged
    {
        public GuestModel Parent { get; set; }
        public test(GuestModel p)
        {
            this.Parent = p;
           
        }
        /*public bool mozeLiPotvrda(object parametar)
        { return true; }
        public void potvrdi(object parametar)
        {
            Parent.NavigationService.GoBack();
        }
        private void Vm_ErrorsChanged(object sender,
        System.ComponentModel.DataErrorsChangedEventArgs e)
        { //event koji ce se pozvati kad dodje do neispravne validacije
          //daj sve greske i pretvori ih u listu stringova da se mogu ispisati
            Erori = new ObservableCollection<string>(Kartica.Errors.Errors.Values.SelectMany(x =>
           x).ToList());
        }
        //mora biti observableCollection i pozvati OnNotifyPropertyChanged da bi se primjetila promjena liste da bi view skontao da se mora izmjeniti
        private ObservableCollection<string> erori;
        public ObservableCollection<string> Erori
        {
            get { return erori; }
            set
            {
                erori = value;
                OnNotifyPropertyChanged("Erori");
            }
        }
        //implementacija INotifyPropertyChanged interfejsa koji ova klasa implementira
        */public event PropertyChangedEventHandler PropertyChanged;
        protected void OnNotifyPropertyChanged([CallerMemberName] string memberName = "")
        { //? je skracena verzija ako nije null
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(memberName));
        }
    }
}