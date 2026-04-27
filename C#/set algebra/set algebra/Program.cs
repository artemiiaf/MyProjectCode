using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set_algebra
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] oneArray = { 1, 2, 3 };
            int[] twoArray = { 3, 4, 5 };

            int[] associationArray = new int [5];
            int f = 0;


            for (int i = 0; i < oneArray.Length; i++) { 
                for(int j = 0; j < twoArray.Length; j++)
                {
                    if(oneArray[i] != twoArray[j]) {
                        associationArray[f] = oneArray[i];
                        f++;
                    }
                     
                }
            }

                for (int i = 0; i < oneArray.Length; i++)
                {
                    Console.Write(oneArray[i]);

                }

                Console.WriteLine();

                for (int j = 0; j < twoArray.Length; j++)
                {
                    Console.Write(twoArray[j]);
                }









        }
    }
}
