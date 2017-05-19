using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    class Admin : Account
    {
        public List<Message> Inbox;
        public Admin()
        {
            Inbox = new List<Message>();
        }
    }
}
