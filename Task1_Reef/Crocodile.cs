using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Crocodile : Reptile
    {
        protected bool istoothtip { get; set; }
        public Crocodile(string name, int age, bool istal, double cals, double tailength,bool istoothtip):base(name,age, istal, cals,tailength)
        {
            this.istoothtip = istoothtip;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nistoothtip:{istoothtip}";
        }
    }
}
