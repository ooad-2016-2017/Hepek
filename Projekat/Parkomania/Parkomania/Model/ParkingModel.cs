using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    class ParkingModel
    {
        public double Length;
        public double Width;
        public List<Tuple<int, Location>> Locations;
        public List<bool> Free;
        public int brojParkingMjesta;
        public ParkingModel(double l, double w)
        {
            Length = l;
            Width = w;
            Locations = new List<Tuple<int, Location>>();
            Free = new List<bool>();
            brojParkingMjesta = 0;
        }
        public void addLocation(Location l)
        {
            Locations.Add(new Tuple<int, Location>(brojParkingMjesta++, l));
            Free.Add(true);
        } 
        public bool isFree(int i)
        {
            return Free[i];
        }
    }
}
