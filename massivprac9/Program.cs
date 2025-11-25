using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Табель оценок 9Б (Рус.яз, Ин.яз, Мат, Инф, Физ)");
            string[] stud =
            {
                "Семенов-5-5-5-5-5",
                "Волочкова-4-5-4-5-4",
                "Сидоров-5-4-5-4-5",
                "Романова-4-4-4-4-3",
                "Николаев-3-4-3-5-4",
                "Бустеров-5-5-3-4-3",
                "Волкова-4-3-5-3-4",
                "Крид-3-5-4-4-2",
                "Белова-4-3-3-3-3",
                "Жуков-3-3-4-5-3",
            };
            Console.WriteLine();
            foreach (string tabel in stud)
            {
                var part = tabel.Split('-');
                Console.Write($"{part[0]}: ");
                for (int i = 1; i < part.Length; i++)
                {
                    Console.Write($"{part[i]}, ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Введите средний балл");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Ученики со средним баллом выше {a}:");
            foreach (string tab in stud)
            {
                var part = tab.Split('-');
                string name = part[0];
                double sum = 0;
                for (int i = 1; i < part.Length; i++)
                {
                    sum += Convert.ToDouble(part[i]);
                }
                double sred = sum / (part.Length - 1);
                if (sred > a)
                {
                    Console.WriteLine($"{name}: {sred:f1}");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Успеваимость по предметам:");
            string[] sub = { "Рус.яз", "Ин.яз", "Матем", "Информатика", "Физика" };
            double[] best = new double[sub.Length];
            for (int i = 0; i < sub.Length; i++)
            {
                double summ = 0;
                foreach (string tab in stud)
                {
                    var part = tab.Split('-');
                    summ += Convert.ToDouble(part[i + 1]);
                }
                best[i] = summ / stud.Length;
                Console.WriteLine($"{sub[i]}: {best[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Предмет с наивысшей успеваимостью:");
            double max = 0;
            string bub = "";
            for (int i = 0; i < best.Length; i++)
            {
                if (best[i] > max)
                {
                    max = best[i];
                    bub = sub[i];
                }
            }
            Console.WriteLine($"{bub}: {max}");
            Console.WriteLine();
            string[] ret = new string[stud.Length];
            for (int i = 0; i < ret.Length; i++)
            {
                var part = stud[i].Split('-');
                string name = part[0];
                double sum = 0;
                for (int j = 1; j < part.Length; j++)
                {
                    sum += Convert.ToDouble(part[j]);
                }
                double sred = sum / (part.Length - 1);
                ret[i] = $"{name}-{sred}";
            }
            var rit = ret.OrderByDescending(r => Convert.ToDouble(r.Split('-')[1]));
            int kol = 1;
            foreach (string r in rit)
            {
                Console.WriteLine($"{kol}.  {r.Split('-')[0]} -- {r.Split('-')[1]}");
                kol++;
            }
            Console.WriteLine();
            Console.WriteLine("---- Отличники ----");
            foreach (string tab in stud)
            {
                var part = tab.Split('-');
                var name = part[0];
                int five = 0;
                for (int j = 1; j < part.Length; j++)
                {
                    if (part[j] == "5")
                    {
                        five++;
                    }
                }
                if (five == part.Length - 1)
                {
                    Console.WriteLine($"  --  {name}  --  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("---- Нормисы ----");
            foreach (string tab in stud)
            {
                var part = tab.Split('-');
                var name = part[0];
                int four = 0;
                int three = 0;
                int two = 0;
                for (int i = 1; i < part.Length; i++)
                {
                    if (part[i] == "4")
                    {
                        four++;
                    }
                    if (part[i] == "3")
                    {
                        three++;
                    }
                    if (part[i] == "2")
                    {
                        two++;
                    }
                }
                if (four > 0 && three == 0 && two == 0)
                {
                    Console.WriteLine($"  --  {name}  --  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("---- Троечники ----");
            foreach (string tab in stud)
            {
                var part = tab.Split('-');
                string name = part[0];
                int three = 0;
                int two = 0;
                for (int i = 1; i < part.Length; i++)
                {
                    if (part[i] == "3")
                    {
                        three++;
                    }
                    if (part[i] == "2")
                    {
                        two++;
                    }
                }
                if (three > 0 && two == 0)
                {
                    Console.WriteLine($"  --  {name}  --  ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"---- Двоечники ----");
            foreach (string tab in stud)
            {
                var part = tab.Split('-');
                var name = part[0];
                int two = 0;
                for (int j = 1; j < part.Length; j++)
                {
                    if (part[j] == "2")
                    {
                        two++;
                    }
                }
                if (two > 0)
                {
                    Console.WriteLine($"---  {name}  ---");
                }
            }
        }
    }
}
