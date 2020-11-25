namespace formEtablisement
{
    internal class Ecole
    {
        private string Nom;
        private string Ville;
        private string Email;

        public Ecole(string nom, string ville, string email)
        {
            this.Nom = nom;
            this.Ville= ville;
            this.Email = email;
        }
    }
}