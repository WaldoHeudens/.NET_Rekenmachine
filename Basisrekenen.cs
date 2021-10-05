using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekenmachine
{
    internal class Basisrekenen
    {
        public double X {  get; set; }
        public double Y {  get; set; }

        public double Optellen()
        {
            return X + Y;
        }
        public double Aftrekken()
        {
            return X - Y;
        }
        public double Vermenigvuldigen()
        {
            return X * Y;
        }
        public double Delen()
        {
            return X + Y;
        }

     }
}
