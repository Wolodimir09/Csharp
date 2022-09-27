using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        public delegate double MyCalcDel(double a, double b);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            try
            {
                Console.WriteLine("Введіть 2 числа: ");
                double value1 = double.Parse(Console.ReadLine());
                double value2 = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------  \nРезультат розрахунків: ");
                MyCalcDel calcDel = MyMath.Add;
                calcDel += MyMath.Mult;
                calcDel += MyMath.Sub;


                foreach (MyCalcDel item in calcDel.GetInvocationList())
                {
                    switch (item.Method.Name)
                    {
                        case "Add": { Console.Write($"{value1} + {value2} = "); } break;
                        case "Mult": { Console.Write($"{value1} * {value2} = "); } break;
                        case "Sub": { Console.Write($"{value1} - {value2} = "); } break;
                    }
                    Console.WriteLine(item(value1, value2));
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
