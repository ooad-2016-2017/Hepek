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
    class UserModel
    {
        System parent;
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand exit { get; set; }
        public ICommand findme { get; set; }
        public Model.User user;

        private string _search;
        public string search
        {
            get { return _search; }
            set
            {
                _search = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(search)));
                }
            }
        }
        public UserModel(System s)
        {
            parent = s;

            exit = new RelayCommand<object>(Exit, check);
            findme = new RelayCommand<object>(findMe, check);
        }
        public bool check(object parametar)
        {
            return true;
        }
        public void Exit(object parametar)
        {
            parent.NavigationService.GoBack();
        }
        public void findMe(object parametar)
        {

        }
    }
}
