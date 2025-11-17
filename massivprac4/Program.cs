using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите размерность массива:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] massiw = new int[a];
            Random r = new Random();
            for (int i = 0; i < a; i++)
            {
                massiw[i] = r.Next(0, 11);
                Console.Write(massiw[i] + " ");
            }
            Console.WriteLine();
            int b = 0;
            for (int i = 0; i < massiw.Length; i++)
            {
                if (massiw[i] != 0)
                {
                    b++;
                }
            }
            int[] masa = new int[b];
            int s = 0;
            for (int i = 0; i < a; i++)
            {
                if (massiw[i] != 0)
                {
                    masa[s] = massiw[i];
                    s++;
                }
            }
            for (int i = 0; i < b; i++)
            {
                Console.Write(masa[i] + " ");
            }
        }
    }
}
