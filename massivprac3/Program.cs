using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] massiw = new int[15];
            Random r = new Random();
            for (int i = 0; i < massiw.Length; i++)
            {
                massiw[i] = r.Next(1, 50);
                Console.Write(massiw[i] + " ");
            }
            Console.WriteLine();
            int max = massiw[0];
            int min = massiw[0];
            int ras = 0;
            int sred = 0;
            int sum = 0;
            for (int i = 0; i < massiw.Length; i++)
            {
                sum += massiw[i];
            }
            for (int i = 0; i < massiw.Length; i++)
            {
                if (massiw[i] >= max)
                {
                    max = massiw[i];
                }
                else if (massiw[i] <= min)
                {
                    min = massiw[i];
                }
            }
            ras = max - min;
            sred = sum / massiw.Length;
            Console.WriteLine($"Максимальный элемент массива: {max}");
            Console.WriteLine($"Минимальный элемент массива: {min}");
            Console.WriteLine($"Разница между максимальным и минимальным числом: {ras}");
            Console.WriteLine($"Все элементы массива, которые больше среднего значения({sred}):");
            for (int i = 0; i < massiw.Length; i++)
            {
                if (massiw[i] > sred)
                {
                    Console.Write(massiw[i] + " ");
                }
            }
        }
    }
}
