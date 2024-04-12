using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex03_LINQ.Entities;

namespace Ex03_LINQ.Exercices
{
    internal class Exercice6
    {
        public void Run()
        {
            List<Personne> personnes = new List<Personne>()
            {
                new Personne("Garett", "Ramzy", 45, "M"),
                new Personne("Caire", "Joe", 35, "M"),
                new Personne("Clay", "Alicia", 18, "F"),
                new Personne("Bavette", "Simone", 68, "F"),
                new Personne("Henry", "Thierry", 44, "M"),
                new Personne("Jacquesonne", "Janett", 25, "F"),
                new Personne("Buveur", "Joe", 25, "M"),
                new Personne("Louet", "Karim", 31, "M"),
                new Personne("Louette", "Karima", 31, "F"),
                new Personne("Caire", "Paul", 19, "M"),
                new Personne("Mille", "Camille", 20, "F"),
                new Personne("Cent", "Camille", 40, "F"),
                new Personne("Million", "Camille", 60, "M"),
                new Personne("Gold", "Roger", 17, "M"),
                new Personne("Lion", "Sandra", 8, "F"),
                new Personne("René", "Jean", 6, "M")
            };

            //1. Faire un group by sur le genre (sexe) des personnes présentes dans la liste d'objets Personne()
//            var querySexe =

            //Affiche les valeurs possibles pour Sexe
//            foreach (var item in querySexe) 
//            {
//            }

            Console.WriteLine("----------------------------------");

            //2. Faire un group by sur l'âge des personnes. Faire un tri croissant par âge.
            //            var queryAge = 

            //Affiche les valeurs possibles pour Sexe
//            foreach (var item in queryAge) 
//            { 
//            }

            Console.WriteLine("----------------------------------");

            //3. Faire un group by sur le prénom des personnes, et afficher les noms de famille par prénom.
            //Trier les prénoms par ordre décroissant.
            //Récupérer les personnes majeures (18 ans et plus)
//            var queryPrenom = 

//            foreach (var item in queryPrenom)
//            {
//            }

            Console.WriteLine("----------------------------------");

            //4. Grouper les éléments d'une liste de nombres. D'un côté les chiffres/nombres pairs, de l'autre ceux impairs.
            List<int> nombres = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 11, 13, 12, 14, 18, 17, 16, 14, 14 };

//            var queryPair =

        //    foreach (var item in queryPair)
        //    {
        //    }

            Console.WriteLine("----------------------------------");

            //5 Grouper les individus par la première lettre de leur nom et faire un tri croissant sur l'attribut Nom de la classe Personne
//            var queryInitiale =

//            foreach (var item in queryInitiale)
//            {
//            }
        }
    }
}
