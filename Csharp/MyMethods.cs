using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal static class MyMethods
    {
        // Метод відображення поточного часу
        public static void NewTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
        // Метод відображення поточної дати;
        public static void NewDate() => Console.WriteLine(DateTime.Now.ToShortDateString());
        //Метод відображення поточного дня тижня;
        public static void NewDayOfWeek() => Console.WriteLine(DateTime.Now.DayOfWeek.ToString());
        // Метод для підрахунку площі трикутника;
        public static double AreaOfTheTriangle(double height, double side) => 0.5*side*height;
        //Метод для підрахунку площі прямокутника
        public static double AreaOfTheRectangle(double sideA, double sideB) => sideA * sideB;

    }
}
