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

            try
            {
                Console.Write("Введіть число: ");
                int value1 = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------  \nРезультат розрахунків: ");
                Predicate<int> predicat = MyMath.Pair;
                predicat += MyMath.Unmathed;
                predicat += MyMath.PrimeNumber;
                predicat += MyMath.FibonachiBool;


                foreach (Predicate<int> item in predicat.GetInvocationList())
                {
                    switch (item.Method.Name)
                    {
                        case "Pair": { Console.Write("Перевірка числа на парність:\t"); } break;
                        case "Unmathed": { Console.Write("Перевірка числа на непарність:\t"); } break;
                        case "PrimeNumber": { Console.Write("Перевірка на просте число:\t"); } break;
                        case "FibonachiBool": { Console.Write("Перевірка на число Фібоначчі:\t"); } break;
                    }
                    Console.WriteLine(item(value1));
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
        }
    }
}
