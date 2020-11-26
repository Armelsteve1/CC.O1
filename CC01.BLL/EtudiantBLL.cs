using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtudiantBLL
    {
        EtudiantDAL etudiantRepo;
        public EtudiantBLL(string dbFolder)
        {
            etudiantRepo = new EtudiantDAL (dbFolder);
        }
        public void CreateEtudiant(Etudiant etudiant)
        {
            etudiantRepo.Add(etudiant);
        }

        public void DeleteEtudiant(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }


        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return etudiantRepo.Find();
        }


        public IEnumerable<Etudiant> GetByMatricule(string matricule)
        {
            return etudiantRepo.Find(x => x.Matricule == matricule);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditEtudiant(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            etudiantRepo.Set(oldEtudiant, newEtudiant);
        }
    }
}
