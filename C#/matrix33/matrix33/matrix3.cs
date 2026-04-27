using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix33
{
    internal class matrix3
    {
        public double matrix(
                 double x1, double x2, double x3,
                 double b1, double b2, double b3,
                 double z1, double z2, double z3)
        {
          return ((x1 * b2 * z3) + (x2 * b3 * z1) + (x3 * b1 * z2)) - ((z1 * b2 * x3) + (b1 * x2 * z3) + (b3 * z2 * x1));
           
        }
    }
}
