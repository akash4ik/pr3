using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP33
{
    internal class Class4 : Interface1
    {
        public int dada(int a, int b)
        { return a / b; }

        int Interface1.Dada(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
