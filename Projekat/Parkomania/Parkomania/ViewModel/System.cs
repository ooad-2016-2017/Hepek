using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.ViewModel
{
    public static class System
    {
        public static List<Model.Parking> parkings;
        public static List<Model.User> users;
        public static List<Model.Admin> admins;
        static System()
        {
            parkings = new List<Model.Parking>();
            users = new List<Model.User>();
            admins = new List<Model.Admin>();
        }
    }
}
