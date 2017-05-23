using Parkomania.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Parkomania.ViewModel
{
    class ParkingViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public NavigationService NavigationService { get; set; }
        System parent;
        public Model.Parking parking;
        public ParkingViewModel(System s)
        {
            parent = s;
        }
        public ParkingViewModel()
        {
            apply = new RelayCommand<object>(Apply, check);
        }
        public ICommand apply { get; set; }
        public bool check(object parametar)
        {
            return true;
        }
        public void Apply(object parametar)
        {

        }
        public string Val;
        public string Valuta
        {
            get { return Val; }
            set
            {
                Val = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Valuta)));
                }
            }
        }
        public string freeS;
        public string freeSpaces
        {
            get { return freeS; }
            set
            {
                freeS = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(freeSpaces)));
                }
            }
        }
        public string pr;
        public string price
        {
            get { return pr; }
            set
            {
                pr = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(price)));
                }
            }
        }
        public string fr;
        public string from
        {
            get { return fr; }
            set
            {
                fr = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(from)));
                }
            }
        }
        public string un;
        public string until
        {
            get { return un; }
            set
            {
                un = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(until)));
                }
            }
        }
    }
}
