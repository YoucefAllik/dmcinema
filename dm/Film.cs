using System;

namespace dm
{
    public class Film
    {
        private int annee;
        private string genre;
        private int idfilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film(int annee, string genre, int idfilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idfilm = idfilm;
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;
        }

        public int Annee { get => annee; set => annee = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Idfilm { get => idfilm; set => idfilm = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Titre { get => titre; set => titre = value; }

        public Acteur GetActeurPrincipal()
        {
            return acteurPrincipal;
        }

        public static Film getInstance(int annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            return new Film(annee, genre, idFilm, resume, titre, acteurPrincipal);
        }

        public string GetGenre()
        {
            return genre;
        }

        public int GetIdFilm()
        {
            return idfilm;
        }

        public int GetAnnee()
        {
            return annee;
        }

        public string GetTitre()
        {
            return titre;
        }

        public string GetResume()
        {
            return resume;
        }

        public override string ToString()
        {
            return $"Titre : {titre}\nAnnée : {annee}\nGenre : {genre}\nRésumé : {resume}\nActeur Principal : {acteurPrincipal.Nom} {acteurPrincipal.Prenom}";
        }
    }
}
