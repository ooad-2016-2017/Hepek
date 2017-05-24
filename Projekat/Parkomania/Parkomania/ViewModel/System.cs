using Parkomania.Helper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parkomania.ViewModel
{
    public class System : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public NavigationService NavigationService { get; set; }

        public static List<Model.Parking> parkings;
        public static List<Model.User> users;
        public static List<Model.Admin> admins;
        public static List<Model.Account> acc;
        
        public ICommand LoginGosta { get; set; }
        public ICommand Login { get; set; }
        public ICommand register { get; set; }
        public ICommand confirm { get; set; }
        public ICommand regParking { get; set; }
        public ICommand forgotpass { get; set; }
        public ICommand cancel { get; set; }
        public ICommand send { get; set; }
        public ICommand sendcode { get; set; }
        public ICommand addparking { get; set; }

        //welcome
        private string _email;
        private string _password;
        public string email
        {
            get { return _email; }
            set
            {
                _email = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(email)));
                }
            }
        }
        public string pass
        {
            get { return _password; }
            set
            {
                _password = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(pass)));
                }
            }
        }
        
        //registerforma
        private string fn;
        private string ln;
        private string em;
        private string pw;
        private bool cb;
        public string firstname
        {
            get { return fn; }
            set
            {
                fn = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(firstname)));
                }
            }
        }
        public string lastname
        {
            get { return ln; }
            set
            {
                ln = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(lastname)));
                }
            }
        }
        public string Email
        {
            get { return em; }
            set
            {
                em = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }
        public string pasw
        {
            get { return pw; }
            set
            {
                pw = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(pasw)));
                }
            }
        }
        private string rpass;
        public string rpasw
        {
            get { return rpass; }
            set
            {
                rpass = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(rpasw)));
                }
            }
        }
        public bool CheckBoxIsChecked
        {
            get { return cb; }
            set
            {
                cb = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(CheckBoxIsChecked)));
                }
            }
        }
        //forgot password
        public string emailfp;
        public string ecfp;
        public string emailforgotpass
        {
            get { return emailfp; }
            set
            {
                emailfp = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(emailforgotpass)));
                }
            }
        }
        public string entercode
        {
            get { return ecfp; }
            set
            {
                ecfp = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(entercode)));
                }
            }
        }
        //parking register
        public string drzava;
        public string country
        {
            get { return drzava; }
            set
            {
                drzava = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(country)));
                }
            }
        }
        public string grad;
        public string city
        {
            get { return grad; }
            set
            {
                grad = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(city)));
                }
            }
        }
        public string parkingname;
        public string pname
        {
            get { return parkingname; }
            set
            {
                parkingname = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(pname)));
                }
            }
        }
        public string kapacitet;
        public string capacity
        {
            get { return kapacitet; }
            set
            {
                kapacitet = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(capacity)));
                }
            }
        }
        public string cijena;
        public string price
        {
            get { return cijena; }
            set
            {
                cijena = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(price)));
                }
            }
        }
        public string starttime;
        public string stime
        {
            get { return starttime; }
            set
            {
                starttime = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(stime)));
                }
            }
        }
        public string endtime;
        public string etime
        {
            get { return endtime; }
            set
            {
                endtime = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(etime)));
                }
            }
        }
        public string freeplaces;
        public string freep
        {
            get { return freeplaces; }
            set
            {
                freeplaces = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(freep)));
                }
            }
        }

        //Admin

        public System()
        {
            using (var db = new dbContext.Parking())
            {
                //parkings = db.parking.ToList<Model.Parking>();
                //users = db.user.ToList<Model.User>();
                //admins = db.admin.ToList<Model.Admin>();
                //acc = db.account.ToList<Model.Account>();
            }
            LoginGosta = new RelayCommand<object>(openGuestForm, check);
            Login = new RelayCommand<object>(openLoginForm, check);
            register = new RelayCommand<object>(openReg, check);
            confirm = new RelayCommand<object>(addUser, check);
            regParking = new RelayCommand<object>(openRegParking, check);
            forgotpass = new RelayCommand<object>(forgotpassform, check);
            cancel = new RelayCommand<object>(Cancel, check);
            send = new RelayCommand<object>(Send, check);
            sendcode = new RelayCommand<object>(SendCode, check);
            addparking = new RelayCommand<object> (AddParking, check);
            NavigationService = new NavigationService();
        }
        //ParkingRegister
        public void AddParking(object parametar)
        {

        }
        //Forgot password
        public void Send(object parametar)
        {

        }
        public void SendCode(object parametar)
        {

        }
        public void Cancel(object parametar)
        {
            this.NavigationService.GoBack();
        }
        public void forgotpassform(object parametar)
        {
            NavigationService.Navigate(typeof(ForgotPassword), this);
        }

        public void openGuestForm(object parametar)
        {
            email = "";
            pass = "";
            NavigationService.Navigate(typeof(GlavnaForma), new GuestModel(this));
        }
        public bool check(object parametar)
        {
            return true;
        }
        public void openLoginForm(object parametar)
        {
            foreach (Model.Account a in acc)
                if (a.Email() == _email && a.Password() == MD5.ComputeMD5(_password))
                {
                    email = "";
                    pass = "";
                    if (a.Acctype() == "admin")
                        NavigationService.Navigate(typeof(Admin), this);
                    else if (a.Acctype() == "user")
                        NavigationService.Navigate(typeof(GlavnaFormaLogin), new UserModel(this));
                    else if (a.Acctype() == "parking")
                        NavigationService.Navigate(typeof(ParkingForm), new ParkingViewModel(this));
                }
        }
        public void openReg(object parametar)
        {
            NavigationService.Navigate(typeof(LoginForma), this);
        }
        public void addUser(object parametar)
        {
            using (var db = new dbContext.Parking())
            {
                var ac = new Model.Account(fn, ln, em, MD5.ComputeMD5(pw), "user");
                db.account.Add(ac);
                db.SaveChanges();

                var us = new Model.User
                {
                    locationid = 0
                };

                db.user.Add(us);
                db.SaveChanges();

                firstname = string.Empty;
                lastname = string.Empty;
                Email = string.Empty;
                pasw = string.Empty;
                cb = false;
                rpasw = string.Empty;
            }
        }
        public void openRegParking(object parametar)
        {
            email = "";
            pass = "";
            NavigationService.Navigate(typeof(ParkingRegister), this);
        }
    }
}
