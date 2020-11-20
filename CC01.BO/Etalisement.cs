using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Etalisement
    {
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Reference { get; set; }

        public Etalisement(string nom, string email, string reference)
        {
            Nom = nom;
            Email = email;
            Reference = reference;
        }

        public Etalisement()
        {
        }
    }
}
