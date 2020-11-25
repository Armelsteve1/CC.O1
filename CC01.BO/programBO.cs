using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class programBO
    {
        class Ecole
        {
            public string Nom { get; set; }
            public string Ville{ get; set; }
            public string Email { get; set; }

            public Ecole(string nom, string ville, string email)
            {
                Nom = nom;
                Ville =ville ;
                Email = email;
            }

            public Ecole()
            {
            }
        }
        class Etudiants
        {
            public string nom { get; set; }
            public string prenom { get; set; }
            public string date_naisse { get; set; }
            public DateTime Identifiant { get; set; }
            public string contacte { get; set; }
            public string Email { get; set; }

            public Etudiants(string nom, string prenom, string date_naisse, DateTime identifiant, string contacte, string email)
            {
                this.nom = nom;
                this.prenom = prenom;
                this.date_naisse = date_naisse;
                Identifiant = identifiant;
                this.contacte = contacte;
                Email = email;
            }

            public Etudiants()
            {
            }

            public override bool Equals(object obj)
            {
                return obj is Etudiants etudients &&
                       Identifiant == etudients.Identifiant;
            }

            public override int GetHashCode()
            {
                return 574969646 + Identifiant.GetHashCode();
            }
        }
    }
}
