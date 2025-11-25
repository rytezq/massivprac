using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string[] workers = { "Иванов Алексей Петрович,Программист","Петрова Мария Ивановна,Менеджер","Сидоров Дмитрий Сергеевич,Программист","Козлова Анна Владимировна,Дизайнер","Иванова Екатерина Олеговна,Менеджер"};
          Console.WriteLine("Все сотрудники:");
          for (int i = 0; i < workers.Length; i++)
          {
             Console.WriteLine(workers[i]);
          }              
          Console.Write("Введите должность: ");
          string job = Console.ReadLine();
          Console.WriteLine($"Люди с должностью {job}:");
          for (int i = 0; i < workers.Length; i++)
          {                  
          string[] parts = workers[i].Split(',');
          string name = parts[0];    
          string position = parts[1]; 
          if (position.ToLower() == job.ToLower())
          {
             Console.WriteLine(name);
          }
          }           
          Console.Write("Введите букву: ");
          char letter = Console.ReadLine()[0];

          Console.WriteLine($"Фамилии на букву {letter}:");      
          for (int i = 0; i < workers.Length; i++)
          {
          string[] parts = workers[i].Split(',');
          string name = parts[0];              
          if (name[0] == letter)
          {
          Console.WriteLine(workers[i]);
          }
          }           
          Console.WriteLine("Отсортированный список:");
          foreach (string worker in workers.OrderBy(w => w.Split(',')[0]))
          {
              Console.WriteLine(worker.Split(',')[0]);
          }
        }
    }
}
