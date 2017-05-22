using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    public class Account
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string acctype { get; set; }

        public Account() { }
        public Account(string fn, string ln, string em, string pass)
        {
            firstname = fn;
            lastname = ln;
            email = em;
            password = pass;
            acctype = "";
        }
    }
}
