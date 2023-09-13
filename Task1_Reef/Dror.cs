using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Dror:Bird
    {
        protected Colors makorcolor { get; set; }
        protected Colors bodycolor { get; set; }
        public Dror(Colors makorcolor,Colors bodycolor,string name, int age, bool istal, double cals, int flhight, int wingslength) :base(name,age, istal, cals, flhight, wingslength)
        {
            this.bodycolor = bodycolor;
            this.makorcolor = makorcolor;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nmakorcolor:{makorcolor}\nbodycolor:{bodycolor}";
        }
    }
}
