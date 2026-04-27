using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] russianAlphabet = {
    'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й',
    'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф',
    'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я',
    'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й',
    'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф',
    'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'
};

            int[] digits = {
    23, 45, 12, 67, 34, 89, 5, 71, 42, 18,
    56, 3, 78, 29, 61, 14, 50, 37, 82, 9,
    44, 21, 63, 7, 55, 32, 74, 16, 48, 25,
    59, 2, 69, 40, 86, 11, 53, 30, 77, 19,
    64, 8, 41, 27, 72, 13, 57, 35, 80, 4,
    46, 22, 68, 10, 52, 38, 84, 15, 60, 31,
    75, 17, 49, 26, 70, 1
};

            Console.WriteLine("Введите текст для шифровки:");
            string data = Console.ReadLine();
            string coder  = "";
            char[] letters = data.ToCharArray();

            foreach (char letter in letters)
            {
              


                for (int i = 0; i < russianAlphabet.Length; i++)
                {
                    if (russianAlphabet[i] == letter)
                    {                        
                        coder += digits[i] + " ";
                        break;
                    }
                }

                
            }

            Console.WriteLine($"\nЗашифрованный текст: {coder}");






            Console.WriteLine("Введите текст для расшифровки:");
            string dedata = Console.ReadLine();
            string decoder = "";
            char[] deletters = dedata.ToCharArray();

            string[] numberStrings = dedata.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string numStr in numberStrings)
            {

                if (int.TryParse(numStr, out int number))
                {


                    for (int i = 0; i < digits.Length; i++)
                    {
                        if (digits[i] == number) 
                        {
                            decoder += russianAlphabet[i]; 
                            break;
                        }
                    }

                }
            }



            Console.WriteLine($"\nрасшифрованный текст: {decoder}");
        }
    }
}
