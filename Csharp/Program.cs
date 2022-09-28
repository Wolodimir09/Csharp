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
            Console.WriteLine("\t\tРішення задачі 1");
            Problem1();
            Console.WriteLine("\t\tРішення задачі 2");
            Problem2();            
        }        

        // Рішення задачі 1
        private static void Problem1()
        {
            try
            {
                Console.Write("Введіть масив цілих чисел через пробіл: ");
                int[] myArr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);

                Console.WriteLine("----------------------------  \nРезультат розрахунків: ");
                MyArrayDel arrayDel = MyArray.EvenNumbers;
                arrayDel += MyArray.AnOddNumbers;
                arrayDel += MyArray.Primes;
                arrayDel += MyArray.FibonacciNumbers;


                foreach (MyArrayDel item in arrayDel.GetInvocationList())
                {
                    switch (item.Method.Name)
                    {
                        case "EvenNumbers": { Console.Write("\nПарні елементи: "); } break;
                        case "AnOddNumbers": { Console.Write("\nНепарні елементи: "); } break;
                        case "Primes": { Console.Write("\nПрості числа: "); } break;
                        case "FibonacciNumbers": { Console.Write($"\nЧисла Фібоначі: "); } break;
                    }
                    foreach (var item2 in item(myArr))
                    {
                        Console.Write(item2 + " ");
                    }
                }
            }
            catch (MemberAccessException member)
            {
                Console.WriteLine(member.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n-------------------------------------------------");
        }
        // Рішення задачі 2
        private static void Problem2()
        {
            try
            {
                Action action = MyMethods.NewTime;
                action += MyMethods.NewDate;
                action += MyMethods.NewDayOfWeek;

                foreach (Action item in action.GetInvocationList())
                {
                    switch (item.Method.Name)
                    {
                        case "NewTime": { Console.Write("Поточний час: "); } break;
                        case "NewDate": { Console.Write("Поточна дата: "); } break;
                        case "NewDayOfWeek": { Console.Write("Поточний день тижня: "); } break;                        
                    }
                    item();
                }
                Console.WriteLine("-------------------------------------------");
                Console.Write("Введіть висоту трикутника: ");
                double height = double.Parse(Console.ReadLine());
                Console.Write("Введіть довжину основи трикутника: ");
                double side = double.Parse(Console.ReadLine());
                Func<double,double,double> funcTriangle = (value1 ,value2) => (0.5 * value1 * value2);
                Console.WriteLine("Площа трикутника: "+funcTriangle(side, height));
                Console.WriteLine("-------------------------------------------");
                Console.Write("Введіть висоту прямокутника: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Введіть ширину прямокутника: ");
                double sideB = double.Parse(Console.ReadLine());
                Func<double, double, double> funcRectangle = (value1, value2) => (value1 * value2);
                Console.WriteLine("Площа прямокутника: " + funcRectangle(sideA, sideB));
            }
            catch (MemberAccessException member)
            {
                Console.WriteLine(member.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n-------------------------------------------------");
        }
    }
}
