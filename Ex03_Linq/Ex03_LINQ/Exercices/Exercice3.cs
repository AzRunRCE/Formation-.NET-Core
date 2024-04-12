using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex03_LINQ.Entities;

namespace Ex03_LINQ.Exercices
{
    internal class Exercice3
    {
        public void Run()
        {
            List<Personne> personnes = new List<Personne>
            {
                new Personne("Hallyday", "Johnny", false),
                new Personne("Vartan", "Sylvie", false),
                new Personne("Drucker", "Michel", false),
                new Personne("Antoine", "Antoine", true),
                new Personne("Philippe", "Edouard", false),
                new Personne("Demorand", "Patricia", true),
                new Personne("Ulysse", "Margareth", true),
                new Personne("Zenith", "Méryl", true),
                new Personne("Bobo", "Jojo", false)
            };

            //1. Créer un itérable d'ingénieurs, trier par nom, et ensuite par prénom
//            var queryIngenieurs =


            //2. Récupérer la liste des personnes qui ne sont pas ingénieures.
//            var queryTechniciens = 


            //3. Créer une liste d'objets anonymes (Ingénieurs + techniciens)
//            var queryAnonymous = 


//            foreach (var item in queryIngenieurs)
//            {
//                Console.WriteLine(item.nom_complet);
//            }

        }

    }

 }

