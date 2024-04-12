using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex03_LINQ.Entities;

namespace Ex03_LINQ.Exercices
{

    internal class Exercice4
    {
        public void Run()
        {
            List<Personne> personnes = new List<Personne>
            {
                new Personne("Beauvoir", "Simon", 16, "M"),
                new Personne("Beauvoir", "Simone", 25, "F"),
                new Personne("De Caunes", "Richard", 41, "M"),
                new Personne("Sullivan", "Sullivan", 31, "M"),
                new Personne("Rémy", "Camille", 22, "F"),
                new Personne("Manchon", "Camille", 19, "M"),
                new Personne("Thiebaud", "Marie", 61, "F"),
                new Personne("Crouchon", "Mélanie", 55, "F"),
                new Personne("Baline", "Mélodie", 74, "F"),
                new Personne("Karine", "Pascal", 31, "M"),
                new Personne("Katherine", "Pascale", 36, "F"),
                new Personne("Zoula", "Charles", 20, "M"),
                new Personne("Romain", "Collin", 34, "M"),
                new Personne("Fouchard", "Aïcha", 48, "F"),
                new Personne("Blandine", "Maëva", 18, "F")
            };

                //Créer une variable majeur qui est égale à True si l'âge de la personne est supérieure ou égale à 18
                //sinon False
//                var query = 


                //Créer une variable "initiale" qui contient seulement les initiales du nom et du prénom : p.Nom[0]+"."+p.Prenom[0]
                //Sélectionner seulement les personnes majeures (18 ans et plus)
                //Sélectionner également les personnes âgées de moins de 50 ans
                //Créer une variable taille_nom_complet = longueur du prénom + longueur du nom
                //Créer un objet anonyme avec les attributs : Nom, prénom, initiale, taille_nom_complet, age

//                var bigQuery = 

                //Affichage du résultat de la requête
//                foreach (var item in bigQuery)
//                {
//                    Console.WriteLine(item.Nom + " " + item.Prenom + " " + item.Initiale + " " + item.Taille_nom_complet + " " + item.Age);
//                }

            }

        }

    }
