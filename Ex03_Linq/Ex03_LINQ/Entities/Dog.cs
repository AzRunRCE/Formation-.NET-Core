using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_LINQ.Entities
{
    internal class Dog
    {
        private string race;
        private string name;
        private int age;
        private int weight;

        public Dog(string race, string name, int age, int weight)
        {
            this.race = race;
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public string Race
        {
            get
            {
                return this.race;
            }
            set
            {
                this.race = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
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

        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

    }
}
