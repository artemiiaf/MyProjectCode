using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace НВП_с_восстановлением_ответа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] a = { 2, 0, 10, 9, 28, 27, 31 };
            int k = 0;
            int j = 0;
            int key = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < key)
                {

                }
                else
                {
                    k++;
                    key = a[i];
                }
            }

                    int[] b = new int[k];
                    key = a[0];

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] < key)
                {

                }
                else
                {
                    b[j] = a[i];
                    j++;
                    key = a[i];
                }
            }

            for (int i = 0; i < b.Count(); i++)
            {
                Console.WriteLine(b[i]);
            }




        }
    }
}
