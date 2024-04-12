using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_LINQ.Entities
{
    internal class Chien
    {
        string nom;
        string surnom;
        string race;
        string couleur;
        string sexe;
        int age;
        int poids;

        public Chien(string nom, string surnom, string race, string couleur, string sexe, int age, int poids)
        {
            this.nom = nom;
            this.surnom = surnom;
            this.race = race;
            this.couleur = couleur;
            this.sexe = sexe;
            this.age = age;
            this.poids = poids;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
        }

        public string Surnom
        {
            get
            {
                return this.surnom;
            }
        }

        public string Race
        {
            get
            {
                return this.race;
            }
        }

        public string Couleur
        {
            get
            {
                return this.couleur;
            }
        }

        public string Sexe
        {
            get
            {
                return this.sexe;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public int Poids
        {
            get
            {
                return this.poids;
            }
        }
    }
}

