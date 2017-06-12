using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class ParkingModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id;
        public int places { get;  set;}
        public ParkingModel() { }
        public ParkingModel(int x)
        {
            places = x;
        }
    }
}
