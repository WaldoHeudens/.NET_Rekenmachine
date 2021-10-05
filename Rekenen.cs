using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    internal class Rekenen:Basisrekenen
    {
        public double Machtsverheffing()
        {
            return Math.Pow(X, Y);
        }
        public double Kwadraat()
        {
            return Math.Pow(X, 2);
        }
        public double Vierkantswortel()
        {
            return Math.Pow(X, 0.5);
        }

        public double Worteltrekking()
        {
            return Math.Pow(X, 1/Y);
        }
    }
}
