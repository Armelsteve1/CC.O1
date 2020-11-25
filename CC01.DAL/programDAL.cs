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
    public class programDAL
    {
        private string dbfolder;

        public programDAL(string dbfolder)
        {
            this.dbfolder = dbfolder;
        }

        public class Ecole
        {
            private static List<Ecole> ecoles;
            private const string FILE_NAME = @"ecoles.json";
            private readonly string dbFolder;
            private FileInfo file;


            public Ecole(string dbFolder)
            {
                this.dbFolder = dbFolder;
                //file = new FileInfo(FILE_NAME);
                file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME)); //combine les 2 pour former un chemin complete
                if (!file.Directory.Exists)
                {
                    file.Directory.Create(); // pour tester si le fichier 'data' n'existe pas et le cas si non
                }
                if (!file.Exists)
                {
                    file.Create().Close(); // pour cree le fichier .json si il n'existe pas \ .close pour la feremeture du flux
                }
                if (file.Length > 0)
                {
                    //file = new FileInfo(FILE_NAME);
                    using (StreamReader sr = new StreamReader(file.FullName, false)) //*****
                    {
                        string json = sr.ReadToEnd();
                        ecoles = JsonConvert.DeserializeObject<List<Ecole>>(json);
                    }
                }
                if (ecoles == null)
                {
                    ecoles = new List<Ecole>(); //pour instancier le liste si elle est nulle
                }

            }

            public void Set(Ecole oldproduct, Ecole newproduct)
            {
                var oldIndex = ecoles.IndexOf(oldproduct);
                var newIndex = ecoles.IndexOf(newproduct);

                if (oldIndex < 0)
                    throw new KeyNotFoundException("Product reference doesn't exists !");

                if (newIndex > 0 && newIndex != oldIndex)
                    throw new DuplicateNameException("thos product already exists !");

                ecoles[oldIndex] = newproduct;
                Save();

            }

            public void Add(Ecole ecole)
            {
                var index = ecoles.IndexOf(ecole);
                if (index >= 0)
                    throw new DuplicateNameException("Product reference already exist !");

                ecoles.Add(ecole); //ajouter un produit a la liste de produit
                Save();
            }
            public void Remove(Ecole ecole)
            {
                ecoles.Remove(ecole); //il vas utiliser la methodes equals pour savoir si les 2 produit ont la meme reference
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

        }

        public void Find()
        {
            throw new NotImplementedException();
        }

        public void Remove(Ecole ecole)
        {
            throw new NotImplementedException();
        }

        public void Add(Ecole ecole)
        {
            throw new NotImplementedException();
        }

        public class Etudiant
        {
            private static List<Etudiant> etudiants;
            private const string FILE_NAME = @"ecoles.json";
            private readonly string dbFolder;
            private FileInfo file;


            public Etudiant(string dbFolder)
            {
                this.dbFolder = dbFolder;
                //file = new FileInfo(FILE_NAME);
                file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME)); //combine les 2 pour former un chemin complete
                if (!file.Directory.Exists)
                {
                    file.Directory.Create(); // pour tester si le fichier 'data' n'existe pas et le cas si non
                }
                if (!file.Exists)
                {
                    file.Create().Close(); // pour cree le fichier .json si il n'existe pas \ .close pour la feremeture du flux
                }
                if (file.Length > 0)
                {
                    //file = new FileInfo(FILE_NAME);
                    using (StreamReader sr = new StreamReader(file.FullName, false)) //*****
                    {
                        string json = sr.ReadToEnd();
                        etudiants = JsonConvert.DeserializeObject<List<Etudiant>>(json);
                    }
                }
                if (etudiants == null)
                {
                    etudiants = new List<Etudiant>(); //pour instancier le liste si elle est nulle
                }

            }

            public void Set(Etudiant oldEtudiant, Etudiant newEtudiant)
            {
                var oldIndex = etudiants.IndexOf(oldEtudiant);
                var newIndex = etudiants.IndexOf(newEtudiant);

                if (oldIndex < 0)
                    throw new KeyNotFoundException("Product reference doesn't exists !");

                if (newIndex > 0 && newIndex != oldIndex)
                    throw new DuplicateNameException("thos product already exists !");

                etudiants[oldIndex] = newEtudiant;
                Save();

            }

            public void Add(Etudiant etudiant)
            {
                var index = etudiants.IndexOf(etudiant);
                if (index >= 0)
                    throw new DuplicateNameException("Product reference already exist !");

                etudiants.Add(etudiant); //ajouter un produit a la liste de produit
                Save();
            }
            public void Remove(Etudiant etudiant)
            {
                etudiants.Remove(etudiant); //il vas utiliser la methodes equals pour savoir si les 2 produit ont la meme reference
                Save();

            }
            public void Save()
            {
                using (StreamWriter sw = new StreamWriter(file.FullName, false))
                {
                    string json = JsonConvert.SerializeObject(etudiants);
                    sw.WriteLine(json);
                }
            }
            public IEnumerable<Etudiant> Find()
            {
                return new List<Etudiant>(etudiants);
            }
            public IEnumerable<Etudiant> Find(Func<Etudiant, bool> predicate)
            {
                return new List<Etudiant>(etudiants.Where(predicate).ToArray());
            }

        }
    }
}
