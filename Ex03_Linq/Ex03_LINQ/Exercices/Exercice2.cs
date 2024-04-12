using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex03_LINQ.Entities;

namespace Ex03_LINQ.Exercices
{
    internal class Exercice2
    {
        public void Run()
        {
            List<Dog> dogs = new List<Dog>
            {
                new Dog("Berger Australien", "Banzaï", 1, 28),
                new Dog("Berger Australien", "Letto", 3, 30),
                new Dog("Berger Australien", "Princesse", 8, 32),
                new Dog("Berger Allemand", "Floyd", 10, 32),
                new Dog("Caniche", "Igor", 13, 9),
                new Dog("Labrador", "Swing", 15, 25),
                new Dog("Teckel", "Wonki", 2, 5),
                new Dog("Terre Neuve", "Albator", 1, 50),
                new Dog("Carlin", "Pataud", 13, 10),
                new Dog("Boxer", "Frank", 6, 25),
                new Dog("Lévrier Afghan", "Précieuse", 9, 26),
                new Dog("Yorkshire", "Kakou", 3, 6)
            };

            //1. Récupérer tous les chiens qui sont de la race "Berger Australien"
//            var query = 

            //1.5. Récupérer tous les chiens qui sont de la race "Berger Australien" et les trier par leur nom
//            var query2 =

            //2. Récupérer tous les chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 lettres
//            var query3 = 

            //2.5 Récupérer tous les chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 lettres
            //Trier les chiens par leur poids
//            var query4 = 

            //3. Trier les chiens par leur âge (tri décroissant) puis leur poids (tri croissant)
 //           var query5 = 

            //4. Récupérer les noms de chien dont le nom de race tient en un seul mot
            //Leur poids doit être supérieur à 15 kilos
            //Leur nom doit contenir un "i"
            //Trier les chiens par la longueur de leur prénom
//            var query6 = 

//            foreach (var item in query)
//            {
//                Console.WriteLine(item.Name);
//            }

        }
    } 
}

