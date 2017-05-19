using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    interface IAdmin
    {
        void addAdmin(Admin a);
        void removeAdmin(Admin a);
    }
}
