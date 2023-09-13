using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Animal
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }

        protected int age { get; set; }
        public int Age { get { return age; } set { age = value; } }

        protected bool istal { get; set; }
        public bool Istal { get { return istal; } set { istal = value; } }

        protected double cals { get; set; }
        public Animal(string name, int age, bool istal, double cals) {
            this.name = name;
            this.age = age;
            this.cals = cals;
            this.istal = istal;
        }
        public override string ToString()
        {
            return $"name:{name}\nage:{age}\nistal:{istal}\ncals:{cals}";
        }
        public double Eat()
        {
            return this.cals * 3;
        }



    }
}
