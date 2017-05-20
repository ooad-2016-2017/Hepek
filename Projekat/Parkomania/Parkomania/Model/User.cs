using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class User : Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public Location location;
        public User(int id, string fn, string ln, string em, string pass) : base(fn, ln, em, pass)
        {

        }
        public void Reserve(Location l)
        {

        }
    }
}
