using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massivprac7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] products = {"Хлеб,50,Выпечка","Молоко,80,Молочные продукты","Сыр,300,Молочные продукты","Яблоки,120,Фрукты","Апельсины,150,Фрукты","Колбаса,250,Мясные продукты","Курица,200,Мясные продукты","Печенье,90,Сладости","Шоколад,120,Сладости","Рис,80,Крупы"};
            Console.WriteLine("Весь каталог товаров:");
            Console.WriteLine("Название|Цена|Категория");
            Console.WriteLine();
            foreach (string product in products)
            {
                string[] parts = product.Split(',');
                Console.WriteLine($"{parts[0]}|{parts[1]}|{parts[2]}");
            }
            Console.Write("Введите категорию для поиска: ");
            string category = Console.ReadLine();

            Console.WriteLine($"Товары в категории '{category}':");
            Console.WriteLine("Название|Цена");
            Console.WriteLine();

            int foundCount = 0;
            foreach (string product in products)
            {
                string[] parts = product.Split(',');
                string name = parts[0];
                string price = parts[1];
                string productCategory = parts[2];

                if (productCategory.ToLower() == category.ToLower())
                {
                    Console.WriteLine($"{name}|{price} руб.");
                    foundCount++;
                }
            }
            if (foundCount == 0)
            {
                Console.WriteLine("Товаров в этой категории не найдено");
            }
            Console.Write("Введите минимальную цену: ");
            int minPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную цену: ");
            int maxPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Товары в диапазоне {minPrice}-{maxPrice} руб.:");
            Console.WriteLine("Название|Цена|Категория");
            Console.WriteLine();
            int foundPriceCount = 0;
            foreach (string product in products)
            {
                string[] parts = product.Split(',');
                string name = parts[0];
                int price = Convert.ToInt32(parts[1]);
                string productCategory = parts[2];

                if (price >= minPrice && price <= maxPrice)
                {
                    Console.WriteLine($"{name} {price} {productCategory}");
                    foundPriceCount++;
                }
            }

            if (foundPriceCount == 0)
            {
                Console.WriteLine("Товаров в этом ценовом диапазоне не найдено");
            }
            Console.WriteLine("Товары отсортированные по цене (от дешевых к дорогим):");
            Console.WriteLine("Название|Цена|Категория");
            Console.WriteLine();
            var sortedProducts = products.OrderBy(p => Convert.ToInt32(p.Split(',')[1])).ToArray();

            foreach (string product in sortedProducts)
            {
                string[] parts = product.Split(',');
                Console.WriteLine($"{parts[0]}\t\t{parts[1]}\t{parts[2]}");
            }
            

        }
    }
}
