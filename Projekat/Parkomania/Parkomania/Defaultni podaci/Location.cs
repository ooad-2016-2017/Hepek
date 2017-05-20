using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Defaultni_podaci
{
    public class Location
    {
        public static void Initialize(dbContext.Parking context)
        {
                Model.ParkingModel test = new Model.ParkingModel(12, 32);
            //Model.Parking te = new Model.Parking(100, "te", "test", "test", 51, 23, 44, 5, 14, 3, test);
            //te.id = 1;
            //context.parking.AddRange(te);
            Model.Location t = new Model.Location(12f, 125f);
            t.id = 245;
                context.location.AddRange(t);
                context.SaveChanges();
        }
    }
}
