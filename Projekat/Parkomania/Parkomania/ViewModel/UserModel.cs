using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.ViewModel
{
    class UserModel
    {
        System parent;
        public Model.User user;
        public UserModel(System s)
        {
            parent = s;
        }
    }
}
