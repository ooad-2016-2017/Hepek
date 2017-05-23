using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class Admin : Account
    {
        public Admin(string fn, string ln, string em, string pass): base(fn,ln,em,pass, "admin")
        {
        }
    }
}
