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
            
            Problem1();
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
            
        }
    }
}
