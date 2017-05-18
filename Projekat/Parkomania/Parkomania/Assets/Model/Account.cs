using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkomania.Model
{
    class Account
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public DateTime createdAt;
        public DateTime updatedAt;
        
        public Account(int id, string fn, string ln, string em, string pass)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
            Email = em;
            Password = pass;
            createdAt = DateTime.Now;
            updatedAt = DateTime.Now;
        }
    }
}
