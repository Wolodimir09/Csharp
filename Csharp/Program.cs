using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    enum ColorsOfRainbow
    {
        Red = 1, Orange = 2, Yellow =3, Green = 4, Cyan = 5, Blue = 6,
        Purple = 7
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.InputEncoding=Encoding.UTF8;
            try
            {
                Console.WriteLine("-------------------- Задача 1 -----------------------");
                Problem1();
                Console.WriteLine("\n-------------------- Задача 3-5 -----------------------");
                Console.Write("Введіть значення масиву цілих цисел чкркз пробіл: ");
                int[] arrayInt = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
                Problem3(arrayInt);
                Problem4(arrayInt);
                Problem5(arrayInt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private static void Problem5(int[] arrayInt)
        {
            Func<int[], int[]> func = (value) => value.Where(e => e < 0).Distinct().ToArray();
            Console.Write("Кількість унікальних негативних значень масиву: ");
            foreach (var item in func(arrayInt))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void Problem4(int[] arrayInt)
        {
            Func<int[], int> func = (value) => value.Where(e => e>0).Count();
            Console.WriteLine("Кількість позитивних значень масиву: " + func(arrayInt));
        }

        private static void Problem3(int[] arrayInt)
        {
            Func<int[],int> func = (value)=>value.Where(e=>e%7==0).Count();
            Console.WriteLine("Кількість значень кратних 7-ми: "+func(arrayInt));
        }

        private static void Problem1()
        {
            Dictionary<string, string> rainbow = new Dictionary<string, string>()
            {
                {"Red","R-255, G-0, B-0"},
                {"Orange","R-255, G-128, B-0" },
                {"Yellow","R-255, G-255, B-0" },
                {"Green","R-0, G-255, B-0" },
                {"Cyan","R-0, G-255, B-255" },
                {"Blue","R-0, G-0, B-255" },
                {"Purple","R-255, G-0, B-255" }
            };

            Func<Dictionary<string, string>, string, string> colorsOfRainbow = delegate (Dictionary<string, string> dicRainbow, string color)
            {
                if (dicRainbow.ContainsKey(color))
                {
                    return dicRainbow[color];
                }
                throw new Exception("Значення не знайдено");
            };            
                Console.Write("Вкажіть один із кольорів веселки англійською: ");
                Console.WriteLine("RGB: " + colorsOfRainbow(rainbow, Console.ReadLine()));            
        }
    }
}
