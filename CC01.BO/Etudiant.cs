using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string PreNom { get; set; }
        public string LieuNais { get; set; }
        public string DateNais { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }
        public byte[] Photo { get; set; }



        public Etudiant()
        {

        }
        public Etudiant(string matricule, string nom, string preNom,
            string dateNais, string lieuNais, string email, long contact, byte[] photo)
        {
            Matricule = matricule;
            Nom = nom;
            PreNom = preNom;
            DateNais = dateNais;
            LieuNais = lieuNais;
            Email = email;
            Contact = contact;
            Photo = photo;



        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
               Matricule.Equals(etudiant.Matricule, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
