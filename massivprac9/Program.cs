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
            string[] students = {"Иванов Алексей,5,4,5,3","Петрова Мария,4,5,4,5","Сидоров Дмитрий,3,3,4,2","Козлова Анна,5,5,5,5","Николаев Павел,2,3,2,3","Орлова Екатерина,4,4,3,4","Федоров Сергей,5,4,5,4","Семенова Ольга,3,4,3,4"};
            string[] subjects = {"Математика","Физика","Информатика","История"};
            Console.WriteLine("База данных студентов:");
            Console.WriteLine("Имя|Матем|Физика|Информ|История");
            Console.WriteLine();
            foreach (string student in students)
            {
                string[] parts = student.Split(',');
                Console.WriteLine($"{parts[0]} | {parts[1]} | {parts[2]} | {parts[3]} | {parts[4]}");
            }
            Console.Write("Введите минимальный средний балл для поиска: ");
            double minAverage = double.Parse(Console.ReadLine());

            Console.WriteLine($"Студенты со средним баллом выше {minAverage}:");
            Console.WriteLine("Имя|Средний балл");
            Console.WriteLine();

            int foundStudents = 0;
            foreach (string student in students)
            {
                string[] parts = student.Split(',');
                string name = parts[0];

                double sum = 0;
                for (int i = 1; i < parts.Length; i++)
                {
                    sum += int.Parse(parts[i]);
                }
                double average = sum / (parts.Length - 1);

                if (average > minAverage)
                {
                    Console.WriteLine($"{name} | {average:F1}");
                    foundStudents++;
                }
            }

            if (foundStudents == 0)
            {
                Console.WriteLine("Студентов не найдено");
            }
            Console.WriteLine(" Анализ успеваемости по предметам ");

            double[] subjectAverages = new double[subjects.Length];

            for (int subjectIndex = 0; subjectIndex < subjects.Length; subjectIndex++)
            {
                double subjectSum = 0;

                foreach (string student in students)
                {
                    string[] parts = student.Split(',');
                    subjectSum += int.Parse(parts[subjectIndex + 1]);
                }

                subjectAverages[subjectIndex] = subjectSum / students.Length;
                Console.WriteLine($"{subjects[subjectIndex]}: {subjectAverages[subjectIndex]:F1}");
            }
            double maxSubjectAverage = 0;
            string bestSubject = "";

            for (int i = 0; i < subjectAverages.Length; i++)
            {
                if (subjectAverages[i] > maxSubjectAverage)
                {
                    maxSubjectAverage = subjectAverages[i];
                    bestSubject = subjects[i];
                }
            }

            Console.WriteLine($"Предмет с наивысшим средним баллом: {bestSubject} ({maxSubjectAverage:F1})");

            Console.WriteLine("Рейтинг студентов по успеваемости");
            string[] rating = new string[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                string[] parts = students[i].Split(',');
                string name = parts[0];

                double sum = 0;
                for (int j = 1; j < parts.Length; j++)
                {
                    sum += int.Parse(parts[j]);
                }
                double average = sum / (parts.Length - 1);

                rating[i] = $"{name},{average:F2}";
            }

            for (int i = 0; i < rating.Length - 1; i++)
            {
                for (int j = i + 1; j < rating.Length; j++)
                {
                    string[] parts1 = rating[i].Split(',');
                    string[] parts2 = rating[j].Split(',');

                    double avg1 = double.Parse(parts1[1]);
                    double avg2 = double.Parse(parts2[1]);

                    if (avg1 < avg2)
                    {
                        string temp = rating[i];
                        rating[i] = rating[j];
                        rating[j] = temp;
                    }
                }
            }

            Console.WriteLine("Место|Имя|Средний балл");
            Console.WriteLine(" ");
            for (int i = 0; i < rating.Length; i++)
            {
                string[] parts = rating[i].Split(',');
                Console.WriteLine($"{i + 1}\t{parts[0]}\t{parts[1]}");
            }

  
            Console.WriteLine(" Категории студентов ");

            string imbastudents = "Отличники (средний балл ≥ 4.5): ";
            string lohstudents = "Двоечники (средний балл < 3.0): ";
            int imbaCount = 0;
            int lohCount = 0;

            foreach (string student in students)
            {
                string[] parts = student.Split(',');
                string name = parts[0];

                double sum = 0;
                for (int i = 1; i < parts.Length; i++)
                {
                    sum += int.Parse(parts[i]);
                }
                double average = sum / (parts.Length - 1);

                if (average >= 4.5)
                {
                    imbastudents += name + ", ";
                    imbaCount++;
                }
                else if (average < 3.0)
                {
                    lohstudents += name + ", ";
                    lohCount++;
                }
            }

            if (imbaCount > 0)
                Console.WriteLine(imbastudents.TrimEnd(',', ' '));
            else
                Console.WriteLine("Отличников нет");

            if (lohCount > 0)
                Console.WriteLine(lohstudents.TrimEnd(',', ' '));
            else
                Console.WriteLine("Двоечников нет");

            Console.WriteLine("Общая статистика ");

            double totalSum = 0;
            foreach (string student in students)
            {
                string[] parts = student.Split(',');
                for (int i = 1; i < parts.Length; i++)
                {
                    totalSum += int.Parse(parts[i]);
                }
            }

            double overallAverage = totalSum / (students.Length * subjects.Length);
            Console.WriteLine($"Общий средний балл группы: {overallAverage:F2}");
            Console.WriteLine($"Всего студентов: {students.Length}");
            Console.WriteLine($"Отличников: {imbaCount}");
            Console.WriteLine($"Двоечников: {lohCount}");
        }
    }
}
