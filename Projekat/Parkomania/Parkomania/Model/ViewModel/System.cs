using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.ViewModel
{
    class System
    {
        public List<Model.Parking> parkings;
        public List<Model.User> users;
        public List<Model.Admin> admins;
        public System()
        {
            parkings = new List<Model.Parking>();
            users = new List<Model.User>();
            admins = new List<Model.Admin>();
        }
    }
}
