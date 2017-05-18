﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    class Admin : Account
    {
        public List<Message> Inbox;
        public Admin(int id, string fn, string ln, string em, string pass): base(id,fn,ln,em,pass)
        {
            Inbox = new List<Message>();
        }
    }
}
