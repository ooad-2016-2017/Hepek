using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    interface IParking
    {
        void addParking(Parking p);
        void removeParking(Parking p);
    }
}
