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
            Console.WriteLine("-------------------- Задача 1 -----------------------"); 
            Problem1();
            Console.WriteLine("\n-------------------- Задача 3 -----------------------");
            Problem3();
        }

        private static void Problem3()
        {
            throw new NotImplementedException();
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
            try
            {
                Console.Write("Вкажіть один із кольорів веселки англійською: ");
                Console.WriteLine("RGB: " + colorsOfRainbow(rainbow, Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
