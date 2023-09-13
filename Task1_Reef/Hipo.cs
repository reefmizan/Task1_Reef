using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1_Reef
{
    internal class Hipo :Mammal
    {
        protected double fatpricent;
        public double Fatpricent { get { return fatpricent; } set { fatpricent = value; } }
        public Hipo(string name, int age, bool istal, double cals, double milkcal, int prtime, double fatpricent) : base(name, age, istal, cals, milkcal, prtime)
        {
            this.fatpricent = fatpricent;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nfatpricent:{fatpricent}";
        }


    }
}
