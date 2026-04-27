using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaxnat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер матрицы: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числа через пробел:");
            string[] m = Console.ReadLine().Split(' ');

            Console.WriteLine("Поворот 90°:");
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    Console.Write(m[j * n + i] + " ");
                }
                Console.WriteLine();
            }



        }

    }
}
