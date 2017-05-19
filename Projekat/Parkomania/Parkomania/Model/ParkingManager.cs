using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class ParkingManager : Account
    {
        public ParkingManager(int id, string fn, string ln, string em, string pass) : base(id, fn, ln, em, pass)
        {

        }
        public Parking myParking;
        public void sendMessage(string txt)
        {

        }
    }
}
