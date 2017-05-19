using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class Information
    {
        public DateTime cameAt;
        public DateTime leftAt;
        public Location Parking;
        public DateTime Duration;
        public Information(DateTime ca, DateTime lA, Location l, DateTime d)
        {
            cameAt = ca;
            leftAt = lA;
            Parking = l;
            Duration = d;
        }
    }
}
