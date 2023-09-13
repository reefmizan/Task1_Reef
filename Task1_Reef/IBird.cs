using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal interface IBird
    {
        bool Takeoff(object o);
        bool Landing(object o);
        bool Soaring(object o);


    }
}
