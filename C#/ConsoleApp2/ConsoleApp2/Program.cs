using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите d: ");
            double d = Convert.ToDouble(Console.ReadLine());
           
            double r;

            if (x > 1 && y > 2)
            {
                r = x * Math.Sqrt(Math.Pow(d * y, 3));
            }
            else if (x < 0)
            {
                double minEl = y;
                if (minEl < x)
                {
                    minEl = x;
                }
                if (minEl < c)
                {
                    minEl = c;
                }
                r = minEl;
            }
            else
            {
                double maxEl = Math.Pow(Math.Log10(d*x), 2);
                if (maxEl < Math.Pow(y * c, 2)) ;
                r = maxEl;
            }
            Console.WriteLine("ответ: " + r);
            Console.ReadLine();

        }



    }

}