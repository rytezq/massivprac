using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stroki = new string[6];
            for (int i = 0; i < stroki.Length; i++)
            {
                stroki[i] = Console.ReadLine(); 
            }
            string lol = stroki[0];
            for (int i = 1; i < stroki.Length; i++)
            {
                if (stroki[i].Length > lol.Length)
                {
                    lol = stroki[i];
                }
            }
            Console.WriteLine($"Самая длинная строка: {lol}, длина {lol.Length}");
            int lele = 0;
            Console.WriteLine($"Введите слово которое хотите найти:");
            string slova = Console.ReadLine();
            for (int i = 0; i < stroki.Length; i++)
            {
                if (stroki[i] == slova)
                {
                    lele = i;
                    Console.WriteLine($"Индекс слова({stroki[i]}) в массиве равен: {lele+1}");
                }
            }
        }
    }
}
