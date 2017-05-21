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
        public List<bool> places;
        public int brojParkingMjesta;
        public ParkingModel(double l, double w)
        {
            places = new List<bool>();
            brojParkingMjesta = 0;
        }
    }
}
