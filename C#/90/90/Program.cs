using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Введите значение: ");
            int znachenie = int.Parse(Console.ReadLine());

            int[] array;
            int[] userArray = new int[ znachenie];

            
                for (int j = 0; j < znachenie; j++)
                {
                    Console.Write($"Элемент [{j}]: ");
                    userArray[j] = int.Parse(Console.ReadLine());
                     userArray[j] = array[];
                }
            Console.WriteLine(array);




        }
    }
}
