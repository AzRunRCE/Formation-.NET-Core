using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_LINQ.Entities
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private string sexe;
        private bool est_ingenieur;

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }
        public Personne(string nom, string prenom, bool ingenieur)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.est_ingenieur = ingenieur;
        }

        public Personne(string nom, string prenom, int age, string sexe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.sexe = sexe;
        }

        public Personne(string nom, string prenom, int age, string sexe, bool ingenieur)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.sexe = sexe;
            this.est_ingenieur = ingenieur;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value;
            }
        }

        public bool Est_ingenieur
        {
            get
            {
                return this.est_ingenieur;
            }
            set
            {
                this.est_ingenieur = value;
            }
        }

        public string Sexe
        {
            get
            {
                return this.sexe;
            }
            set
            {
                this.sexe = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

    }

    class Ingenieur
    {
        private string nom;
        private string prenom;
        private string specialite;

        public Ingenieur(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public Ingenieur(string nom, string prenom, string specialite)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.specialite = specialite;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value;
            }
        }

        public string Specialite
        {
            get
            {
                return this.specialite;
            }
            set
            {
                this.specialite = value;
            }
        }

    }

    class Technicien
    {
        private string nom;
        private string prenom;

        public Technicien(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }
    }
}
