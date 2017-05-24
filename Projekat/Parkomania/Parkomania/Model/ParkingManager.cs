using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class ParkingManager : Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public ParkingManager(string fn, string ln, string em, string pass) : base(fn, ln, em, pass, "parking")
        {

        }
        public Parking myParking;
        public void sendMessage(string txt)
        {

        }
    }
}
