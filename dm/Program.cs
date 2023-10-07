using dm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {

        /*  Acteur acteurPrincipal = new Acteur(1942, 1, "Ford", "Harrison");
          Film monFilm = new Film(1982, "Science-Fiction", 1, "Test monfilm.", "Blade Runner", acteurPrincipal);
          Console.WriteLine(monFilm.ToString());
          Acteur monActeur = new Acteur(1942, 1, "Ford", "Harrison");
          Console.WriteLine(monActeur.ToString());
      */

        Cinema monCinema = Cinema.GetInstance();

    
        monCinema.AddActeur(1942, 1, "Ford", "Harrison");
        monCinema.AddActeur(1956, 2, "Hanks", "Tom");

   
        monCinema.AddFilm(1982, "Science-Fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner", monCinema.GetActeur(1));
        monCinema.AddFilm(1992, "Animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story", monCinema.GetActeur(2));


        Film film1 = monCinema.GetFilm(1);
        Film film2 = monCinema.GetFilm(2);

    
        Console.WriteLine("Caractéristiques du film :");
        Console.WriteLine("\n");
        Console.WriteLine(film1.ToString());
        Console.WriteLine(film1.GetActeurPrincipal().ToString());
        Console.WriteLine("\n");
        Console.WriteLine("Caractéristiques du film :");
        Console.WriteLine("\n");
        Console.WriteLine(film2.ToString());
        Console.WriteLine(film2.GetActeurPrincipal().ToString());
    }
}



