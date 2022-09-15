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

            Array arr = new Array(12, 3, 2, 5, 12, 35, 67, 5, 12,87);
            Console.WriteLine("------------- Завдання 1 ---------------");
            arr.Show();
            Console.WriteLine("\n---------------------------------------");
            arr.Show("Додаткова інформація до масиву цілих чисел:");
            Console.WriteLine("\n---------------------------------------");

            // Завдання 2


        }
    }
}
