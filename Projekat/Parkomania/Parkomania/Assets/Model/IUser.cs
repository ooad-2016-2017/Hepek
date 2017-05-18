using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    interface IUser
    {
        void addUser(User u);
        void removeUser(User u);
    }
}
