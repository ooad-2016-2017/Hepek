using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class User : Account
    {
        public Location location;
        public User(int id, string fn, string ln, string em, string pass) : base(id, fn, ln, em, pass)
        {

        }
        public void Reserve(Location l)
        {

        }
    }
}
