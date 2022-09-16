using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            ////////////////////////////////////////////////////////////////////
            // Завдання 1 

            Array arr = new Array(12, 3, 2, 5, 12, 35, 67, 5, 12,86);
            Console.WriteLine("\n------------- Завдання 1 ---------------");
            arr.Show();
            Console.WriteLine("\n---------------------------------------");
            arr.Show("Додаткова інформація до масиву цілих чисел:");
            Console.WriteLine("\n////////////////////////////////////////");

            // Завдання 2

            Console.WriteLine("\n------------- Завдання 2 ---------------");            
            Console.WriteLine("Максимальне значення: " + arr.Max());
            Console.WriteLine("Мінімальне значення: " + arr.Min());
            Console.WriteLine("Середнє значення: " + arr.Avg());
            Console.WriteLine("Наявність елементів 5 і 9: " + arr.Search(5) + " || " +
                                                               arr.Search(9));
            Console.WriteLine("////////////////////////////////////////");
           
            // Завдання 3            
            
            Console.WriteLine("\n------------- Завдання 3 ---------------");
            arr.SortAsc();
            arr.Show("Масив після сортування за зростанням:");
            Console.WriteLine("\n---------------------------------------");
            arr.SortDesc();
            arr.Show("Масив після сортування за спаданням:");
            Console.WriteLine("\n---------------------------------------");
            arr.SortByParam(true);
            arr.Show("Масив після сортування за зростанням:");
            Console.WriteLine("\n////////////////////////////////////////");

            // Завдання 4            

            Console.WriteLine("\n------------- Завдання 4 ---------------");
            Console.WriteLine("Кількіть елементів менших 15 = " + arr.Less(15));
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Кількіть елементів ,більших 15 = " + arr.Greater(15));
            Console.WriteLine("\n////////////////////////////////////////");

            // Завдання 5

            Console.WriteLine("\n------------- Завдання 5 ---------------");            
            Console.WriteLine("Парні елементи масиву:");
            arr.ShowEven();
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Непарні елементи масиву:");
            arr.ShowOdd();            
            Console.WriteLine("\n////////////////////////////////////////");

            // Завдання 6
            Console.WriteLine("\n------------- Завдання 6 ---------------");
            Console.WriteLine("Кількість унікальних значень: " + arr.CountDistinct());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Кількість значень рівних 5 = " + arr.EqualToValue(5));
            Console.WriteLine("////////////////////////////////////////");
        }
    }
}
