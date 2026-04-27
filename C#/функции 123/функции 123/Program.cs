using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace функции_123
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = Convert.ToDouble(Console.ReadLine());
            double a2 = Convert.ToDouble(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());


            double a4 = mediana(a1, a2, a3);
            Console.WriteLine(a4);



            static double mediana(double A1, double A2, double A3)
        {
        double  m = 0.5 * Math.Sqrt(2 * Math.Pow(A2, 2) + 2 * Math.Pow(A3, 2) - Math.Pow(A1, 2));
                
                return m;
        }
        }
    }
}
