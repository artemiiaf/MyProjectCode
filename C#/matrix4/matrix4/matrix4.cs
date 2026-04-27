using System;

namespace matrix4
{
    internal class matrix4 
    {
        public double matrix(
                 double x1, double x2, double x3,
                 double b1, double b2, double b3,
                 double z1, double z2, double z3)
        {
            return ((x1 * b2 * z3) + (x2 * b3 * z1) + (x3 * b1 * z2)) - ((z1 * b2 * x3) + (b1 * x2 * z3) + (b3 * z2 * x1));
        }

      
        public double matrix4x4(
          double a1, double a2, double a3, double a4,
          double b1, double b2, double b3, double b4,
          double c1, double c2, double c3, double c4,
          double d1, double d2, double d3, double d4)
        {
            
            double det =
                  a1 * matrix(b2, b3, b4, c2, c3, c4, d2, d3, d4)
                - a2 * matrix(b1, b3, b4, c1, c3, c4, d1, d3, d4)
                + a3 * matrix(b1, b2, b4, c1, c2, c4, d1, d2, d4)
                - a4 * matrix(b1, b2, b3, c1, c2, c3, d1, d2, d3);

            return det;
        }
    }
}