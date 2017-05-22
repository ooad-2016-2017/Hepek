using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.ViewModel
{
    class ParkingViewModel
    {
        System parent;
        public Model.Parking parking;
        public ParkingViewModel(System s)
        {
            parent = s;
        }
    }
}
