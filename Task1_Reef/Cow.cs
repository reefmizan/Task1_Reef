using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Cow : Mammal
    {
        protected int hamlatotnum { get; set; }
        public Cow(string name, int age, bool istal, double cals, double milkcal, int prtime,int hamlatotnum) : base(name,age,istal,cals,milkcal,prtime)

        {
            this.hamlatotnum = hamlatotnum;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nhamlatot:{hamlatotnum}";
        }
        public new double Eat()
        {
            return (base.Eat() / 4.0);
        }
    }
}
