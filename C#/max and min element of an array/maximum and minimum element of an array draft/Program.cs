using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_and_minimum_element_of_an_array_draft
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sizeArray = int.Parse(Console.ReadLine());
            int[] userArray = new int[sizeArray];

            int minNumber = -100;
            int maxNumber = 100;

            Random random = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
                userArray[i] = random.Next(minNumber, maxNumber);

                Console.Write(userArray[i] + " ");
            }

            int maxEl = userArray[0];
            int minEl = userArray[0];
            int indMaxEl = 0;
            int indMinEl = 0;

            for (int i = 0; i < sizeArray; i++)
            {
                if (userArray[i] > maxEl) 
                {  
                    indMaxEl = userArray[i];
                    maxEl = i;
                }

                if (userArray[i] < minEl) 
                { 
                    indMinEl = userArray[i];
                    minEl = i; 
                }
            }


            userArray[maxEl] = indMinEl ;
            userArray[minEl] = indMaxEl ;

            Console.WriteLine();
            
            for (int i = 0;i < sizeArray; i++)
            {
                Console.Write(userArray[i] + " ");
            }


        }
    }
}
