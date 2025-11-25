using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите количество результатов");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] test = new int[a];
            Random random = new Random();
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = random.Next(0, 101);
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Отсортированный список результатов:");
            Array.Sort(test);
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            double med = 0;
            if (test.Length % 2 == 0)
            {
                med = (test[(test.Length / 2) - 1] + test[test.Length / 2]) / 2.0;
            }
            else
                med = test[test.Length / 2];
            Console.WriteLine($"Медиана: {med}");
            Console.WriteLine();
            double sum = 0.0;
            for (int i = 0; i < test.Length; i++)
            {
                sum += test[i];
            }
            double sred = sum / test.Length;
            double summ = 0.0;
            foreach (int i in test)
            {
                double vch = i - sred;
                double kv = Math.Pow(vch, 2);
                summ += kv;
            }
            double sred2 = summ / test.Length;
            double kor = Math.Sqrt(sred2);
            Console.WriteLine($"Среднее отклонение: {kor:F2}");
            Console.WriteLine();
            Console.WriteLine($"Топ-10% лучших результатов:");
            var top10 = test.OrderByDescending(m => m).Take(Convert.ToInt32(Math.Ceiling(test.Length * 0.1)));
            foreach (int i in top10)
            {
                Console.WriteLine($"--- {i} ---");
            }
            Console.WriteLine();
            Console.WriteLine($"Сортировка результатов по группам(НеЗЧ, Неуд, Удовл, Хор, Отл)");
            var lox = test.Where(m => m < 25);
            Console.WriteLine($"Не зачет");
            foreach (int i in lox)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var neyd = test.Where(m => m >= 25 && m < 50);
            Console.WriteLine($"Неудовлетворительно");
            foreach (int i in neyd)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var ydov = test.Where(m => m >= 50 && m < 70);
            Console.WriteLine($"Удовлетворительно");
            foreach (int i in ydov)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var good = test.Where(m => m >= 70 && m < 85);
            Console.WriteLine($"Хорошо");
            foreach (int i in good)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            var imba = test.Where(m => m >= 85);
            Console.WriteLine($"Отлично");
            foreach (int i in good)
            {
                Console.Write(i + " ");
            }
        }
    }
}
