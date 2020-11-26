using CC01.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class EcoleDAL
    {
        private static List<Ecole> ecoles;
        private const string FILE_NAME = "@data/ecole.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EcoleDAL(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    ecoles = JsonConvert.DeserializeObject<List<Ecole>>(json);
                }
            }
            if (ecoles == null)
            {
                ecoles = new List<Ecole>();
            }
        }



        public void Add(Ecole ecole)
        {
            var index = ecoles.IndexOf(ecole);
            if (index >= 0)
                throw new DuplicateNameException("This school name already exists !");
            ecoles.Add(ecole);
            Save();
        }
        public void Set(Ecole oldEcole, Ecole newEcole)
        {
            var oldIndex = ecoles.IndexOf(oldEcole);
            var newIndex = ecoles.IndexOf(newEcole);

            if (oldIndex < 0)
                throw new KeyNotFoundException("School name doesn't exists !");

            if (newIndex > 0 && newIndex != oldIndex)
                throw new DuplicateNameException("this school already exists !");

            ecoles[oldIndex] = newEcole;
            Save();

        }
        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(ecoles);
                sw.WriteLine(json);
            }
        }
        public IEnumerable<Ecole> Find()
        {
            return new List<Ecole>(ecoles);
        }
        public IEnumerable<Ecole> Find(Func<Ecole, bool> predicate)
        {
            return new List<Ecole>(ecoles.Where(predicate).ToArray());
        }
        public void Remove(Ecole ecole)
        {
            ecoles.Remove(ecole);//base sur Product.Equals redefini
            Save();
        }

        public IEnumerable<Ecole> Get()
        {
            return new List<Ecole>(ecoles);
        }
    }

}

