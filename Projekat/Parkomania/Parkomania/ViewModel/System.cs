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
using Windows.UI.Xaml.Controls.Maps;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using EASendMailRT;

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
        public static List<Model.Message> Inbox;
        public static List<Model.ParkingModel> pmodels;
        public static List<Model.ParkingManager> pmanager;
        public static List<Model.Location> locations;

        public MapControl mapa;
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
        public ICommand cancelAddEdit { get; set; }
        public ICommand saveEdit { get; set; }
        public ICommand cancelEdit { get; set; }
        public ICommand saveAddEdit { get; set; }
        public ICommand openAddEdit { get; set; }
        public ICommand deleteMessage { get; set; }

        public System()
        {
            using (var db = new dbContext.Parking())
            {
                parkings = db.parking.ToList<Model.Parking>();
                users = db.user.ToList<Model.User>();
                //admins = db.admin.ToList<Model.Admin>();
                acc = db.account.ToList<Model.Account>();
                //pmodels = db.pmodels.ToList<Model.ParkingModel>();
                locations = db.location.ToList<Model.Location>();
                //inbox = db.inbox.ToList<Model.Message>();
                pmanager = db.pmanager.ToList<Model.ParkingManager>();
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
            addparking = new RelayCommand<object>(AddParking, check);
            cancelAddEdit = new RelayCommand<object>(CancelAddEdit, check);
            saveAddEdit = new RelayCommand<object>(SaveAddEdit, check);
            openAddEdit = new RelayCommand<object>(OpenAddEdit, check);
            deleteMessage = new RelayCommand<object>(DeleteMessage, check);
            cancelEdit = new RelayCommand<object>(Cancel, check);
            NavigationService = new NavigationService();
        }
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
        
        //Admin
        public void OpenAddEdit(object parametar)
        {
            NavigationService.Navigate(typeof(AddEdit), this);
        }
        public string autoSuggestAdmin;
        public string suggestAdmin
        {
            get { return autoSuggestAdmin; }
            set
            {
                autoSuggestAdmin = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(suggestAdmin)));
                }
            }
        }
        public string autoSuggestUser;
        public string suggestUser
        {
            get { return autoSuggestUser; }
            set
            {
                autoSuggestUser = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(suggestUser)));
                }
            }
        }
        public string autoSuggestParking;
        public string suggestParking
        {
            get { return autoSuggestParking; }
            set
            {
                autoSuggestParking = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(suggestParking)));
                }
            }
        }
        public string autoSuggestMessage;
        public string suggestMessage
        {
            get { return autoSuggestMessage; }
            set
            {
                autoSuggestMessage = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(suggestMessage)));
                }
            }
        }
        public void DeleteMessage(object parametar)
        {

        }
        //AddEdit
        public string fnEdit;
        public string firstNameEdit
        {
            get { return fnEdit; }
            set
            {
                fnEdit = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(firstNameEdit)));
                }
            }
        }
        public string lnEdit;
        public string lastNameEdit
        {
            get { return lnEdit; }
            set
            {
                lnEdit = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(lastNameEdit)));
                }
            }
        }
        public string emEdit;
        public string emailEdit
        {
            get { return emEdit; }
            set
            {
                emEdit = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(emailEdit)));
                }
            }
        }
        public string passEdit;
        public string passAddEdit
        {
            get { return passEdit; }
            set
            {
                passEdit = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(passAddEdit)));
                }
            }
        }
        public void CancelAddEdit(object parametar)
        {
            firstNameEdit = "";
            lastNameEdit = "";
            emailEdit = "";
            this.NavigationService.GoBack();
        }
        public void SaveAddEdit(object parametar)
        {

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

        private int brojp = 3;
        //ParkingRegister 
        public void AddParking(object parametar)
        {

            using (var db = new dbContext.Parking())
            {
                var pm = new Model.ParkingModel(brojp);
                db.pmodels.Add(pm);
                db.SaveChanges();

                var lc = new Model.Location
                {
                    //x = ?;
                    //y = ?;
                };
                db.location.Add(lc);
                db.SaveChanges();
               
                int tmp = 0;
                foreach (Model.Account ac in acc)
                    if (ac.Email() == _email)
                        tmp = ac.id;
                var pa = new Model.Parking(tmp, parkingname, grad, drzava, lc.id, (float)Double.Parse(cijena), Int32.Parse(starttime), Int32.Parse(endtime), Int32.Parse(kapacitet), Int32.Parse(freeplaces), pm.id,0);
                db.parking.Add(pa);
                db.SaveChanges();
                IMobileServiceTable<AzureTabela.Parking> userTableObj = App.MobileService.GetTable<AzureTabela.Parking>();
                try
                {
                    AzureTabela.Parking par = new AzureTabela.Parking();
                    par.Accid = tmp;
                    par.Name = parkingname;
                    par.City = grad;
                    par.Country = drzava;
                    par.pLocation = lc.id;
                    par.Price = (float)Double.Parse(cijena);
                    par.startTime = Int32.Parse(starttime);
                    par.endTime = Int32.Parse(endtime);
                    par.Capacity = Int32.Parse(kapacitet);
                    par.freePlaces = Int32.Parse(freeplaces);
                    par.Model = pm.id;
                    par.approved = 0;
                    userTableObj.InsertAsync(par);
                    MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novi parking.");
                    msgDialog.ShowAsync();
                }
                catch (Exception ex)
                {
                    MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                    msgDialogError.ShowAsync();
                }
                var mess = new Model.Message("Add parking Request...", tmp, DateTime.Now);
                db.inbox.Add(mess);
                db.SaveChanges();
            }
                
            

            

            firstname = string.Empty;
            lastname = string.Empty;
            Email = string.Empty;
            pasw = string.Empty;
            cb = false;
            rpasw = string.Empty;
        }
        //Forgot password
        public async void Send(object parametar)
        {
            await Send_Email();
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
        public string e;
        public void openLoginForm(object parametar)
        {
            foreach (Model.Account a in acc)
                if (a.Email() == _email && a.Password() == MD5.ComputeMD5(_password))
                {
                    e = email;
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
                    accid = ac.id
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
        private async Task Send_Email()
        {
            String Result = "";
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");
                SmtpClient oSmtp = new SmtpClient();

                // Set sender email address, please change it to yours
                oMail.From = new MailAddress("admir2404@hotmail.com");

                // Add recipient email address, please change it to yours
                oMail.To.Add(new MailAddress("zlayaa@outlook.com"));

                // Set email subject and email body text
                oMail.Subject = "test email from C# XAML project";
                oMail.TextBody = "this is a test email sent from Windows Store App, do not reply";
                // Your SMTP server address
                SmtpServer oServer = new SmtpServer("smpt.live.com");

                // User and password for SMTP authentication
                oServer.User = "admir2404@hotmail.com"; 
                oServer.Password = "password";
                // If your SMTP server requires TLS connection on 25 port, please add this line
                // oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                // If your SMTP server requires SSL connection on 465 port, please add this line
                oServer.Port = 587;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;

                await oSmtp.SendMailAsync(oServer, oMail);
                Result = "Email was sent successfully!";
            }
            catch (Exception ep)
            {
                Result = String.Format("Failed to send email with the following error: {0}", ep.Message);
            }

            // Display Result by Diaglog box
            Windows.UI.Popups.MessageDialog dlg = new
                Windows.UI.Popups.MessageDialog(Result);

            await dlg.ShowAsync();
        }
    }
}
