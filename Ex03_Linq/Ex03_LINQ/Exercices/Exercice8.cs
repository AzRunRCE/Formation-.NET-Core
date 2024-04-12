﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex03_LINQ.Entities;

namespace Ex03_LINQ.Exercices
{
    internal class Exercice8
    {
        public void Run()
        {
            List<Chien> chiens = new List<Chien>()
            {
                new Chien("Gnocci", "Gnoc Gnoc", "Labrador", "Sable", "M", 1, 20),
                new Chien("Vagabond", "Gros Loup", "Labrador", "Noir", "M", 8, 25),
                new Chien("Milou", "Milos", "Labrador", "Sable", "M", 10, 24),
                new Chien("Sirène", "Sissy", "Labrador", "Sable","F", 4, 19),
                new Chien("Félicia", "Felicci", "Labrador", "Sable", "F", 6, 20),
                new Chien("Kratos", "Mon tueur", "Chihuahua", "Fauve", "M", 1, 2),
                new Chien("Jack", "Jaja", "Chihuahua", "Fauve", "M", 1, 2),
                new Chien("Mojave", "Mojojo", "Chihuahua", "Fauve", "M", 1, 2),
                new Chien("Hercule", "Herc", "Chihuahua", "Beige", "M", 35, 2),
                new Chien("Médusa", "Med", "Terre-Neuve", "Noire", "F", 6, 40),
                new Chien("Mélusine", "Mel", "Terre-Neuve", "Noire", "F", 7, 41),
                new Chien("Venus", "Violette", "Terre-Neuve", "Noire", "F", 8, 38),
                new Chien("Letto", "Lele", "Berger Australien", "Bleu Merle", "M", 3, 30),
                new Chien("Cabron", "Dum dum", "Berger Australien", "Bleu Merle", "M", 9, 31),
                new Chien("Banzaï", "Zaïzaï", "Berger Australien", "Noir et blanc", "M", 1, 28 ),
                new Chien("Haricot", "Harry", "Berger Australien", "Noir et blanc", "M", 2, 27),
                new Chien("Gédéon", "Gégé", "Berger Allemand", "Noir et feu", "M", 9, 31),
                new Chien("Bella", "Belbel", "Berger Allemand", "Noir et feu", "F", 5, 28),
                new Chien("Oui-oui", "oui", "Berger Allemand", "Sable", "M", 7, 35),
                new Chien("Pataud", "Patoche", "Carlin", "Sable", "M", 16, 8),
                new Chien("Killer", "Kiki", "Carlin", "Sable", "M", 10, 8),
                new Chien("Frank", "Colonel", "Carlin", "Noir", "M", 9, 9)
            };

            //1. Faire un group by sur la race des chiens.
            // On veut faire un tri croissant sans utiliser orderby sur l'âge des chiens
//            var querySansInto1 =

//            foreach (var key in querySansInto1)
//            {
//            }

            Console.WriteLine("---------------------------------");

            //2. Faire un group by sur l'âge des chiens et créer ageChiens avec into
            // Trier les chiens par âge (ordre croissant)
            // Faire un group by sur la parité de l'âge (les chiens avec un âge impair d'un côté et pair de l'autre)

//            var queryAgeChiens =

//            foreach (var pair in queryAgeChiens)
//            {
//            }

            //3. Faire un group by sur la race et la couleur des chiens et créer chiensRaceCouleur avec into
            // Trier les chiens par race et par couleur (ordre croissant)

 //           var queryRaceCouleur =

//            foreach (var key in queryRaceCouleur)
//            {
//            }

        }
    }
}

