using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string text;
        public int from;
        public string time;
        public Message(string t, int f, DateTime date)
        {
            text = t;
            from = f;
            time = Convert.ToString(date);
        }
    }
}
