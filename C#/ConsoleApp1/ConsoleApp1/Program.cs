using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());


            double c = Math.Cos(3.14 / 7) * (Math.Pow(Math.Sin(x - (8 * y)), 2) / 2.7 * (x - 3.14));
             
            Console.WriteLine("ответ: "+c);
            Console.ReadLine();

        }

    }
}
