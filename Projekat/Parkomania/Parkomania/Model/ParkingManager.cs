using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class ParkingManager { 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int parkingid { get; set; }
        public ParkingManager(int pid)
        {
            parkingid = pid;
        }
        public Parking myParking;
        public ParkingManager() { }
        public void sendMessage(string txt)
        {

        }
    }
}
