using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_and_min_element_of_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите элемент массива: ");
            int sizeArray = int.Parse(Console.ReadLine());
            int [] userArray = new int [sizeArray];
                
            int minNumber = -100;
            int maxNumber = 100;

            int minimum = userArray.Min();
            int maximum = userArray.Max();

            userArray[0] = minimum;
            userArray[1] = maximum;

            Random random = new Random();

            for (int i = 0; i < sizeArray; i++)
            {
              userArray [i] = random.Next(minNumber, maxNumber);
            }

            foreach (int el in userArray)
            {
            Console.Write(el + " ");
            }

            Console.WriteLine();

                
            

           
          
            

                
                
            
            
            


           


        }
    }
}
