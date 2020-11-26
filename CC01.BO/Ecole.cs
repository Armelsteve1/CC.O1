using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
   public  class Ecole
    {
        public string NomEcole { get; set; }
        public string EmailEcole { get; set; }
        public long ContactEcole { get; set; }
        public byte[] Logo { get; set; }


        public Ecole(byte[] logo, string nom, long tel, string email)
        {
            Logo = logo;
            NomEcole = nom;
            ContactEcole = tel;
            EmailEcole = email;
        }



        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                     NomEcole.Equals(ecole.NomEcole, StringComparison.OrdinalIgnoreCase); ;
        }

        public override int GetHashCode()
        {
            return 217408413 + EqualityComparer<string>.Default.GetHashCode(NomEcole);
        }
    
    }
}
