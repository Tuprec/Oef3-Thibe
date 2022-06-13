using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef3_Thibe
{
    abstract class Dier
    {
        public double dblGewicht;
        public int intAatalPoten;
        public Dier()
        {
            dblGewicht = 0;
            intAatalPoten = 0; 
        }
        public abstract void Geluid();

    }
}
