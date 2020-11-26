using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcoleBLL
    {
        EcoleDAL ecoleRepo;
        private string dbFolder;
        public EcoleBLL(string dbFolder)
        {
            this.dbFolder = dbFolder;
            ecoleRepo = new EcoleDAL(dbFolder);
        }
        public void CreateEcole(Ecole newEcole)
        {
            ecoleRepo.Add(newEcole);

            if (!string.IsNullOrEmpty(newEcole.Logo.ToString()))
                File.Delete(newEcole.Logo.ToString());
        }
        public void DeleteEcole(Ecole ecole)
        {
            ecoleRepo.Remove(ecole);
        }


        public IEnumerable<Ecole> GetAllEcoles()
        {
            return ecoleRepo.Find();
        }


        public IEnumerable<Ecole> GetByNom(string nom)
        {
            return ecoleRepo.Find(x => x.NomEcole == nom);
        }

        public IEnumerable<Ecole> GetBy(Func<Ecole, bool> predicate)
        {
            return ecoleRepo.Find(predicate);
        }

        public void EditEcole(Ecole oldEcole, Ecole newEcole)
        {
            ecoleRepo.Set(oldEcole, newEcole);
        }
    }
}
