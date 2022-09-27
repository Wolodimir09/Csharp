using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public delegate bool PairAnonimDel(int value);
    public delegate int SquareAnonimDel(int value);
    public delegate int CubeDel(int value);
    public delegate int ArrayDel(int[] arr);
    public delegate int[] ArrayDel2(int[] arr);
    internal class Program
    {       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                // Завдання 1
                Console.Write("Введіть ціле число: ");
                int number = int.Parse(Console.ReadLine());
                PairAnonimDel myAnonym = delegate (int value)
                {
                    return value % 2 == 0;
                };
                Console.WriteLine($"Перевірка на парність: {myAnonym(number)}");
                // завдання 2
                SquareAnonimDel sguere = delegate (int value)
                {
                    return value * value;
                };
                Console.WriteLine($"Піднесення до квадрату: {sguere(number)}");
                // завдання 3
                CubeDel cube = (value) => value * value * value;
                Console.WriteLine($"Піднесення до куба: {cube(number)}");
                // завдання 4
                Predicate<int> deyProgramer = (value) => value == 256;
                Console.WriteLine($"День програміста: {deyProgramer(number)}");
                Console.WriteLine("-----------------------------------------------");
                // завдання 5
                Console.Write("Введіть цілочисельні значення масиву через пробіл: ");
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32).ToArray();
                ArrayDel maxElement = (value) => value.Max();
                Console.WriteLine($"Мамксмиальний елемент масиву: {maxElement(arr)}");
                // завдання 6
                ArrayDel minElement = (value) => value.Min();
                Console.WriteLine($"Мінімальний елемент масиву: {minElement(arr)}");                
                // завдання 7
                ArrayDel2 arrayAnOddNumber = (value) =>  value.Where(v => v%2 != 0).ToArray();
                Console.Write("Непарні елементи масиву: ");
                foreach (var item in arrayAnOddNumber(arr))
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine("\n-----------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
