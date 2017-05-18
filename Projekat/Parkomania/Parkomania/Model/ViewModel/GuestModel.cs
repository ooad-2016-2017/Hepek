using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.ViewModel
{
    class GuestModel
    {
        public List<Model.Guest> guests;
        public GuestModel()
        {
            guests = new List<Model.Guest>();
        }
    }
}
