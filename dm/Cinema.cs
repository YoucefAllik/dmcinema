using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm
{
    public class Cinema
    {
        private List<Acteur> lesActeurs;
        private List<Film> lesFilms;

        public Cinema()
        {
            this.lesActeurs = new List<Acteur>();
            this.lesFilms = new List<Film>();
        }

        public static Cinema GetInstance()
        {
            return new Cinema();
        }

        public Acteur GetActeur(int id)
        {
            foreach (Acteur acteur in lesActeurs)
            {
                if (acteur.Id == id)
                {
                    return acteur;
                }
            }
            return null;
        }

        public Film GetFilm(int id)
        {
            foreach (Film film in lesFilms)
            {
                if (film.Idfilm == id)
                {
                    return film;
                }
            }
            return null;
        }

        public int NbActeur()
        {
            return lesActeurs.Count;
        }

        public int NbFilms()
        {
            return lesFilms.Count;
        }

        public void AddFilm(int annee, string genre, int idfilm, string resume, string titre, Acteur acteurPrincipal)
        {
            Film film = new Film(annee, genre, idfilm, resume, titre, acteurPrincipal);
            lesFilms.Add(film);
        }

        public void AddActeur(int anneenaissance, int id, string nom, string prenom)
        {
            Acteur acteur = new Acteur(anneenaissance, id, nom, prenom);
            lesActeurs.Add(acteur);
        }
    }
}
