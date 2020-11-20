using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    class Etudients
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string date_naisse { get; set; }
        public DateTime Identifiant { get; set; }
        public string contacte{ get; set; }
        public string Email { get; set; }

        public Etudients(string nom, string prenom, string date_naisse, DateTime identifiant, string contacte, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.date_naisse = date_naisse;
            Identifiant = identifiant;
            this.contacte = contacte;
            Email = email;
        }

        public Etudients()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Etudients etudients &&
                   Identifiant == etudients.Identifiant;
        }

        public override int GetHashCode()
        {
            return 574969646 + Identifiant.GetHashCode();
        }
    }
}
