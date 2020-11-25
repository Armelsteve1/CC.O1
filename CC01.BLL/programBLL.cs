using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CC01.DAL;
using static CC01.DAL.programDAL;

namespace CC01.BLL
{
    public class programBLL
    {
        programDAL ecolerepo;
        public programBLL(string dbfolder)
        {
            ecolerepo = new programDAL(dbfolder);
        }

        public void createcole(Ecole ecole)
        {
            ecolerepo.Add(ecole);
        }
        public void Deleteecole(Ecole ecole)
        {
            ecolerepo.Remove(ecole);
        }
        public IEnumerable<Ecole> GetAllecole()
        {
            return ecolerepo.Find();
        }
    }
}
