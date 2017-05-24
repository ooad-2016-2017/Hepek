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
        private string firstname { get; set; }
        public string Firstname()
        {
            return firstname;
        }
        public void Firstname(string value)
        {
            firstname = value;
        }
        private string lastname { get; set; }
        public string Lastname()
        {
            return lastname;
        }
        public void Lastname(string value)
        {
            lastname = value;
        }
        private string email { get; set; }
        public string Email()
        {
            return email;
        }
        public void Email(string value)
        {
            email = value;
        }
        private string password { get; set; }
        public string Password()
        {
            return password;
        }
        public void Password(string value)
        {
            password = value;
        }
        private string acctype { get; set; }
        public string Acctype()
        {
            return acctype;
        }
        public void Acctype(string value)
        {
            acctype = value;
        }
        public Account() { }
        public Account(string fn, string ln, string em, string pass, string t)
        {
            firstname = fn;
            lastname = ln;
            email = em;
            password = pass;
            acctype = t;
        }
    }
}
