using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal class Python: Snake
    {
        protected Colors bcolor { get; set; }
        protected int teethsize { get; set; }
        public Python(string name, int age, bool istal, double cals, double tailength, bool isarsi,Colors bcolor, int teethsize):base(name,age, istal, cals,tailength,isarsi)   
        {
            this.bcolor = bcolor;
            this.teethsize = teethsize;
        }
        public new string ToString()
        {
            return base.ToString() + $"\nbcolor:{bcolor}\nteethsize:{teethsize}";
        }
    }
}
