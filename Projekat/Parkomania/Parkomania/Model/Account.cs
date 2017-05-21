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
        public int id;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        
        public Account(string fn, string ln, string em, string pass)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            Password = pass;
        }
    }
}
