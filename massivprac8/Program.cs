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
            int[] testresults = { 85, 92, 78, 45, 67, 88, 95, 72, 60, 81, 53, 90, 75, 68, 82 };

            Console.WriteLine("Результаты тестирования:");
            for (int i = 0; i < testresults.Length; i++)
            {
                Console.Write(testresults[i] + " ");
            }
            int sum = 0;
            foreach (int result in testresults)
            {
                sum += result;
            }
            double average = (double)sum / testresults.Length;
            Console.WriteLine($"Средний балл: {average:F1}");
            int max = testresults[0];
            int min = testresults[0];

            foreach (int result in testresults)
            {
                if (result > max) max = result;
                if (result < min) min = result;
            }

            Console.WriteLine($"Максимальный балл: {max}");
            Console.WriteLine($"Минимальный балл: {min}");

            int perfect = 0;    
            int good = 0;         
            int norm = 0; 
            int fail = 0;         

            foreach (int result in testresults)
            {
                if (result >= 85)
                    perfect++;
                else if (result >= 70)
                    good++;
                else if (result >= 50)
                    norm++;
                else
                    fail++;
            }

            Console.WriteLine("Распределение по оценкам:");
            Console.WriteLine($"Отлично (85-100): {perfect} студентов");
            Console.WriteLine($"Хорошо (70-84): {good} студентов");
            Console.WriteLine($"Удовлетворительно (50-69): {norm} студентов");
            Console.WriteLine($"Неудовлетворительно (0-49): {fail} студентов");
            int aboveAverage = 0;
            foreach (int result in testresults)
            {
                if (result > average)
                    aboveAverage++;
            }

            double percentAboveAverage = (double)aboveAverage / testresults.Length * 100;
            Console.WriteLine($"Студентов выше среднего балла: {aboveAverage} ({percentAboveAverage:F1}%)");
            int[] sortresults = new int[testresults.Length];
            Array.Copy(testresults, sortresults, testresults.Length);

            for (int i = 0; i < sortresults.Length - 1; i++)
            {
                for (int j = i + 1; j < sortresults.Length; j++)
                {
                    if (sortresults[i] > sortresults[j])
                    {
                        int temp = sortresults[i];
                        sortresults[i] = sortresults[j];
                        sortresults[j] = temp;
                    }
                }
            }
            double median;
            if (sortresults.Length % 2 == 0)
            {
                median = (sortresults[sortresults.Length / 2 - 1] + sortresults[sortresults.Length / 2]) / 2.0;
            }
            else
            {
                median = sortresults[sortresults.Length / 2];
            }

            Console.WriteLine($"Медиана: {median:F1}");
            Console.WriteLine("Отсортированные результаты (по возрастанию):");
            foreach (int result in sortresults)
            {
                Console.Write(result + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Статистика по диапазонам баллов:");
            int range90_100 = 0; 
            int range80_89 = 0; 
            int range70_79 = 0; 
            int range60_69 = 0; 
            int range0_59 = 0;  

            foreach (int result in testresults)
            {
                if (result >= 90) range90_100++;
                else if (result >= 80) range80_89++;
                else if (result >= 70) range70_79++;
                else if (result >= 60) range60_69++;
                else range0_59++;
            }

            Console.WriteLine($"90-100 баллов: {range90_100} студентов");
            Console.WriteLine($"80-89 баллов: {range80_89} студентов");
            Console.WriteLine($"70-79 баллов: {range70_79} студентов");
            Console.WriteLine($"60-69 баллов: {range60_69} студентов");
            Console.WriteLine($"0-59 баллов: {range0_59} студентов");
        }
    }
}
