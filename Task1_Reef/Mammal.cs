using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Mammal:Animal
    {
        protected double milkcal { get; set; }
        protected int prtime { get; set; }
        public Mammal(string name, int age, bool istal, double cals, double milkcal, int prtime):base(name, age, istal, cals)

        {

            this.milkcal = milkcal;
            this.prtime = prtime;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nmilkcal:{milkcal}\nprtime:{prtime}";
        }
        public new double Eat()
        {
            return (this.milkcal + base.Eat());
        }
    }
}
