using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Reptile : Animal,IReptile
    {
        protected double tailength { get; set; }
        public Reptile(string name, int age, bool istal, double cals, double tailength)
            :base(name,age,istal,cals)
        {
            
            this.tailength = tailength;
        }
        public new string ToString()
        {
            return  base.ToString() + $"\ntailength:{tailength}";
        }

        public bool Craw(object o)
        {
            return o==null;
        }

        public bool Defence(object o)
        {
            return o==null;
        }

        public bool BodyTempCheck(object o)
        {
            return o == null;
        }
    }
}
