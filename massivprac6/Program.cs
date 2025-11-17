using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperatures = new int[30];
            Random random = new Random();
            for (int i = 0; i < temperatures.Length; i++)
            {
                temperatures[i] = random.Next(-15, 36);
            }
            Console.WriteLine("   Температуры за 30 дней:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.Write(temperatures[i] + " ");
                if ((i + 1) % 7 == 0)
                {
                    Console.WriteLine();
                }

            }
            Console.WriteLine();
            Console.WriteLine("Анализ по неделям");

            int maxWeekSum = -1000; 
            int minWeekSum = 1000;  
            int maxWeekNumber = 1;  
            int minWeekNumber = 1;  
            for (int week = 0; week < 4; week++)
            {
                int weekSum = 0;
                for (int day = 0; day < 7; day++)
                {
                    int dayIndex = week * 7 + day;
                    if (dayIndex < temperatures.Length)
                    {
                        weekSum += temperatures[dayIndex];
                    }
                }

                Console.WriteLine($"Неделя {week+1}: средняя температура = {weekSum / 7.0:F1}°C");
                if (weekSum > maxWeekSum)
                {
                    maxWeekSum = weekSum;
                    maxWeekNumber = week + 1;
                }
                if (weekSum < minWeekSum)
                {
                    minWeekSum = weekSum;
                    minWeekNumber = week + 1;
                }
            }

            Console.WriteLine($"\nСамая теплая неделя: {maxWeekNumber} (средняя: {maxWeekSum / 7.0:F1}°C)");
            Console.WriteLine($"Самая холодная неделя: {minWeekNumber} (средняя: {minWeekSum / 7.0:F1}°C)");
            int totalSum = 0;
            foreach (int temp in temperatures)
            {
                totalSum += temp;
            }
            double averageTemp = totalSum / 30.0;

            Console.WriteLine($"Средняя температура за месяц: {averageTemp:F1}°C");
            Console.WriteLine("Дни, когда температура была выше средней:");
            for (int i = 0; i < temperatures.Length; i++)
            {
                if (temperatures[i] > averageTemp)
                {
                    Console.WriteLine($"День {i + 1}: {temperatures[i]}°C");
                }
            }
            Console.WriteLine(" Группировка температур ");

            int moroz = 0;    
            int holodno = 0;  
            int teplo = 0;    
            int zharko = 0;   

            foreach (int temp in temperatures)
            {
                if (temp < 0)
                    moroz++;
                else if (temp <= 10)
                    holodno++;
                else if (temp <= 20)
                    teplo++;
                else
                    zharko++;
            }

            Console.WriteLine($"Мороз (< 0°C): {moroz} дней");
            Console.WriteLine($"Холодно (0-10°C): {holodno} дней");
            Console.WriteLine($"Тепло (11-20°C): {teplo} дней");
            Console.WriteLine($"Жарко (> 20°C): {zharko} дней");
        }
    }
}
