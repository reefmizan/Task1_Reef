using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Reef
{
    internal interface IReptile
    {
        bool Craw(object o);
        bool Defence(object o);
        bool BodyTempCheck(object o);
    }
}
