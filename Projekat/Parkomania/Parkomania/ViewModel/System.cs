using KompShopMVVM.KompShop.Helper;
using Parkomania.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Parkomania.ViewModel
{
    public class System : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
      
        public static List<Model.Parking> parkings;
        public static List<Model.User> users;
        public static List<Model.Admin> admins;
        public static List<Model.Account> acc;
        
        public ICommand LoginGosta { get; set; }
        public ICommand Login { get; set; }
        public ICommand register { get; set; }
        public ICommand confirm { get; set; }
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

        public System()
        {
            using (var db = new dbContext.Parking())
            {
                //parkings = db.parking.ToList<Model.Parking>();
                //users = db.user.ToList<Model.User>();
                //admins = db.admin.ToList<Model.Admin>();
                acc = db.account.ToList<Model.Account>();
            }
            LoginGosta = new RelayCommand<object>(openGuestForm, check);
            Login = new RelayCommand<object>(openLoginForm, check);
            register = new RelayCommand<object>(openReg, check);
            confirm = new RelayCommand<object>(addUser, check);
        }

        public void openGuestForm(object parametar)
        {
            NavigationService.Navigate(typeof(GlavnaForma), new GuestModel(this));
        }
        public bool check(object parametar)
        {
            return true;
        }
        public void openLoginForm(object parametar)
        {
            foreach (Model.Account a in acc)
                if (a.email == _email && a.password == MD5.ComputeMD5(_password))
                {
                    if (a.acctype == "admin")
                        NavigationService.Navigate(typeof(Admin), this);
                    else if (a.acctype == "user")
                        NavigationService.Navigate(typeof(GlavnaFormaLogin), new UserModel(this));
                    else if (a.acctype == "parking")
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
                var ac = new Model.Account
                {
                    firstname = fn,
                    lastname = ln,
                    email = em,
                    password = MD5.ComputeMD5(pw),
                    acctype = "user"
                };
                db.account.Add(ac);
                db.SaveChanges();

                /*var us = new Model.User
                {
                    locationid = 0
                };
                db.user.Add(us);
                db.SaveChanges();*/

                firstname = string.Empty;
                lastname = string.Empty;
                Email = string.Empty;
                pasw = string.Empty;
                cb = false;
            }
        }
    }
}
