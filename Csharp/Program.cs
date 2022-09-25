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
            // Оголошуються та ініціалізуються тестові зразки масивів 
            var arrayInt = new MyGenericArray<int>(12, 45, 98, 23, 41, 9, 4, 7);
            var arrayByte = new MyGenericArray<byte>(12, 45, 8, 23, 41, 10, 1, 7);
            var arrayDouble = new MyGenericArray<double>(12.32, 5.65, 8.09, 23.17, 41.72, 10.03);
            var arrayChar = new MyGenericArray<char>('f', 'g', 'a', 'n', 'e', 'x');

            try // Проводиться тестова реалізація методів: MaxValue(), MinValue() та Sum() 
            {
                Console.WriteLine("Дано зразки масивів різних значимих типів: ");
                Console.WriteLine($"1. {nameof(arrayInt),-15} {arrayInt,-10}\n" +
                                  $"2. {nameof(arrayByte),-15} {arrayByte,-10}\n" +
                                  $"3. {nameof(arrayDouble),-15} {arrayDouble,-10}\n" +
                                  $"4. {nameof(arrayChar),-15} {arrayChar,-10}");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($" {"Данні:",-15} || {"Max:",-10} || {"Min:",-10} || {"Sum:",-10}");

                Console.Write($" {nameof(arrayInt),-15} || {arrayInt.MaxValue(),-10} ||");
                Console.Write($" {arrayInt.MinValue(),-10} ||");
                Console.Write($" {arrayInt.Sum(),-10}\n");

                Console.Write($" {nameof(arrayByte),-15} || {arrayByte.MaxValue(),-10} ||");
                Console.Write($" {arrayByte.MinValue(),-10} ||");
                Console.Write($" {arrayByte.Sum(),-10}\n");

                Console.Write($" {nameof(arrayDouble),-15} || {arrayDouble.MaxValue(),-10} ||");
                Console.Write($" {arrayDouble.MinValue(),-10} ||");
                Console.Write($" {arrayDouble.Sum(),-10}\n");

                Console.Write($" {nameof(arrayChar),-15} || {arrayChar.MaxValue(),-10} ||");
                Console.Write($" {arrayChar.MinValue(),-10} ||");
                Console.Write($" {arrayChar.Sum(),-10}\n");
            }
            catch (MyTypeException my)
            {
                Console.WriteLine(my.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
