using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace massivprac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1,10);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + " ");
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Сумма всех элементов: {sum} ");
            int sred = sum / numbers.Length;
            Console.WriteLine($"Среднее арифметическое : {sred}");
            int kol = 0;
            for (int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    kol++;
                }
            }
            Console.WriteLine($"Колво четных чисел {kol}");
        }
    }
}
