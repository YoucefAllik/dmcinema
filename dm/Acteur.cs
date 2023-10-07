using System;

namespace dm
{
    public class Acteur
    {
        private int anneenaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur(int anneenaissance, int id, string nom, string prenom)
        {
            this.anneenaissance = anneenaissance;
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int Anneenaissance { get => anneenaissance; set => anneenaissance = value; }
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public static Acteur GetInstance(int anneeNaissance, int id, string nom, string prenom)
        {
            Acteur acteur = new(anneeNaissance, id, nom, prenom);
            return acteur;
        }

        public int GetAnneeNaissance()
        {
            return this.Anneenaissance;
        }
        public string GetNom()
            {
                return this.nom;
            }

        public int GetId()
        {
            return this.id;
        }

        public string GetPrenom()
        {
            return this.prenom;
        }

        public override string ToString()
        {
            return $"Nom : {nom} Prénom : {prenom} Année de naissance : {anneenaissance}";
        }
    }
}
