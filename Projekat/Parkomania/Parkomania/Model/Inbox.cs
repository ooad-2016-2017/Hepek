using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class Message
    {
        public string text;
        public string from;
        public DateTime time;
        public Message(string t, string f)
        {
            text = t;
            from = f;
            time = DateTime.Now;
        }
    }
}
