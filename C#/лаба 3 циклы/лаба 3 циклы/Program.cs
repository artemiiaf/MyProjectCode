using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_3_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            double y;

            
            for (double p = 0; p <= 10; p += 0.5)
            {
                y = 0.5 * Math.Exp(Math.Sin(p)) - p - 1;
                Console.WriteLine(y);
            }
            Console.WriteLine("--------------------------");          
            double x = 0;

            while (x <= 10)
            {
                y = 0.5 * Math.Exp(Math.Sin(x)) - x - 1;
                x += 0.5;
                Console.WriteLine(y);
            }
            Console.WriteLine("--------------------------");
            x = 0;

            do
            {
                y = 0.5 * Math.Exp(Math.Sin(x)) - x - 1;
                x += 0.5;
                Console.WriteLine(y);
            } while (x <= 10);
        }
    }
}