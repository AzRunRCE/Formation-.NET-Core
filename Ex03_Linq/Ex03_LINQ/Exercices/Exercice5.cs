using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex03_LINQ.Entities;

namespace Ex03_LINQ.Exercices
{
    internal class Exercice5
    {
        public void Run()
        {
            List<List<Personne>> personnes = new List<List<Personne>>
            {
                new List<Personne>() {new Personne("Drucker", "Michel"),
                                      new Personne("Bedia", "Ramzy"),
                                      new Personne("Judor", "Eric")},

                new List<Personne>() {new Personne("Diaz", "Cameron"),
                                      new Personne("Depardieu", "Gerard"),
                                      new Personne("Stallone", "Sylvester"),
                                      new Personne("Macron", "Emmanuel")},

                new List<Personne>() {new Personne("Benzema", "Karim"),
                                      new Personne("Antoine", "Eric"),
                                      new Personne("Ruiz", "Olivia"),
                                      new Personne("Clavier", "Christian"),
                                      new Personne("Einstein", "Albert")}
            };


            //1. Récupérer tous les noms dont la longueur est supérieure à 5
//            var query = 

            //2. Récupérer tous les noms contenant un "e"
            //Récupérer tous les prénoms contenant un "a"
            //Trier par nom (tri décroissant)
            //Créer un objet anonyme avec un attribut identite = prénom+" "+nom
//            var query2 = 


            //3. Récupérer toutes les listes qui contiennent plus de 4 personnes
            //Récupérer les personnes dont le nom commence par "A" ou "B" ou "C"
            //Trier les personnes par prénom (tri croissant)
            //Créer un objet anonyme avec l'attribut "initiale" = 1ère lettre du prénom+"."+1ère lettre du nom
//            var query3 = 


            //4. Récupérer toutes les listes qui contiennent moins de 5 personnes
            //Afficher toutes les personnes comme ceci : Nom+" "+Prenom
 //           var query4 = 

            //Affichage du résultat de la requête
 //           foreach (var item in query3)
 //           {
 //               Console.WriteLine(item.Nom + " " + item.Prenom);
 //           }
        }
    }
}
