using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] array =
             {
                {1,5},
                {5,7},
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i,j]);
                }
                Console.WriteLine();
            }

        }
    }
}
