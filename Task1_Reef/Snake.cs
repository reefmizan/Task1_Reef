using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Snake : Reptile
    {
        protected bool isarsi { get; set; }
        public Snake(string name, int age, bool istal, double cals, double tailength, bool isarsi) : base(name,age,istal,cals,tailength)
        {
            this.isarsi = isarsi;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nisarsi:{isarsi}";
        }

    }
}
