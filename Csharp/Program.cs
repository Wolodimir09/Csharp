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
            Console.InputEncoding  =Encoding.Unicode;

            ////////////////// PROBLEM 1 ///////////////////////////////////
            int[] arr = { 28, 1, 7, 56, -2, 12, 8, 123, 14, 78, 32, 9, 21 };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-----------------------------------------");
            Problem1_1(arr); // Копіювання масиву
            Console.WriteLine("\n-----------------------------------------");
            Problem1_2(arr); // Парні цілі числа
            Console.WriteLine("\n-----------------------------------------");
            Problem1_3(arr); // Непарні цілі числа
            Console.WriteLine("\n-----------------------------------------");
            Problem1_4(arr); // Значення більші заданного
            Console.WriteLine("\n-----------------------------------------");
            Problem1_5(arr); // Отримати числа в заданому діапазоні
            Console.WriteLine("\n-----------------------------------------");
            Problem1_6(arr); // Отримати числа, кратні семи. Результат відсортуйте за зростанням
            Console.WriteLine("\n-----------------------------------------");
            Problem1_7(arr); // Отримати числа, кратні восьми. Результат відсортуйте за спаданням
            Console.WriteLine("\n-----------------------------------------");


            //////////////////// PROBLEM 2 ////////////////////////////////

            /*string[] arr = { "Київ", "Одеса", "Львів", "Вінниця", "Харків", "Хмельницький", "Віньківці","Кіров" };
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n-----------------------------------------");
            Problem2_1(arr); // Отримати весь масив міст
            Console.WriteLine("\n-----------------------------------------");
            Problem2_2(arr); // Отримати міста з довжиною назви, що дорівнює заданому
            Console.WriteLine("\n-----------------------------------------");
            Problem2_3(arr); // Отримати міста, назви яких починаються з літери Х
            Console.WriteLine("\n-----------------------------------------");
            Problem2_4(arr); // Отримати міста, назви яких закінчуються літерою В
            Console.WriteLine("\n-----------------------------------------");
            Problem2_5(arr); // Отримати міста, назви яких починаються з літери К і закінчуються літерою В
            Console.WriteLine("\n-----------------------------------------");
            Problem2_6(arr); // Отримати міста, назви яких починаються з Ві. Результат відсортувати за спаданням
            Console.WriteLine("\n-----------------------------------------");*/

            ///////////////////// PROBLEM 3 ////////////////////////

            /*List<Student> students = new List<Student> {
             new Student {
             FirstName = "Петро",
             LastName = "Боднар",
             Years = 18,
             NameGroup = "ВБУ111"
             },
             new Student {
             FirstName = "Михайло",
             LastName = "Прокопенко",
             Years = 22,
             NameGroup = "ВБД112"
             },
             new Student {
             FirstName = "Данило",
             LastName = "Петров",
             Years = 25,
             NameGroup = "ВБУ111"
             },
             new Student {
             FirstName = "Олександр",
             LastName = "Кіров",
             Years = 21,
             NameGroup = "ВБД112"
             }
            };
            Console.WriteLine("\n-----------------------------------------");
            Problem3_1(students); // Отримати весь масив студентів
            Console.WriteLine("\n-----------------------------------------");
            Problem3_2(students); // Отримати список студентів з ім'ям Олександр
            Console.WriteLine("\n-----------------------------------------");
            Problem3_3(students); // Отримати список студентів з прізвищем, яке починається з Про
            Console.WriteLine("\n-----------------------------------------");
            Problem3_4(students); // Отримати список студентів, старших 19 років
            Console.WriteLine("\n-----------------------------------------");
            Problem3_5(students); // Отримати список студентів, старших 20 років і молодших 23 років
            Console.WriteLine("\n-----------------------------------------");
            Problem3_6(students); // Отримати список студентів, які навчаються в групі ВБУ111
            Console.WriteLine("\n-----------------------------------------");
            Problem3_7(students); // Отримати список студентів, які навчаються в Oxford, і вік
                                  // яких старше 18 років. Результат відсортуйте за віком, за спаданням
            Console.WriteLine("\n-----------------------------------------");*/
        }

        private static void Problem3_7(List<Student> students)
        {
            Console.WriteLine("\nСписок студентів, які навчаються в групі ВБД112 і вік " +
                "яких старше 18 років. Відсортованих за віком, за спаданням:");

            var newArr = students.Where(e => e.NameGroup == "ВБД112" &&
                                            e.Years>18).OrderByDescending(e => e.Years);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("-----------------------");
            }
            Console.WriteLine("-----------------------");
        }

        private static void Problem3_6(List<Student> students)
        {
            Console.WriteLine("\nCтуденти, які навчаються в групі ВБУ111: ");

            var newArr = students.Where(e => e.NameGroup == "ВБУ111");
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("-----------------------");
            }
        }

        private static void Problem3_5(List<Student> students)
        {
            Console.WriteLine("\nCписок студентів, старших 20 років і молодших 23 років:");

            var newArr = students.Where(e => e.Years>20 && e.Years<23);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("-----------------------");
            }
        }

        private static void Problem3_4(List<Student> students)
        {
            Console.WriteLine("\nСтуденти, старші 19 років: ");

            var newArr = students.Where(e => e.Years > 19);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("............................");
            }
        }

        private static void Problem3_3(List<Student> students)
        {
            Console.WriteLine("\nСтуденти з прізвищем, яке починається з Про: ");

            var newArr = students.Where(e => e.LastName.StartsWith("Про"));
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("............................");
            }
        }

        private static void Problem3_2(List<Student> students)
        {
            Console.WriteLine("\nСтуденти з ім'ям Олександр:");

            var newArr = students.Where(e => e.FirstName == "Олександр");
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("............................");
            }
        }

        private static void Problem3_1(List<Student> students)
        {
            Console.WriteLine("Масив студентів:");
            Console.WriteLine("-----------------------");
            var newArr = students.Where(e => e != null);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
                Console.WriteLine("............................");
            }
        }

        private static void Problem2_6(string[] arr)
        {
            Console.Write("\nМіста, назви яких починаються з \"Ві\". Відсортованні за спаданням: ");

            var newArr = arr.Where(e => e[0] == 'В' && e[1] == 'і').OrderByDescending(e => e);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem2_5(string[] arr)
        {
            Console.Write("\nМіста, назви яких починаються з літери К і закінчуються літерою \"в\": ");

            var newArr = arr.Where(e => e[0] == 'К'  && e[e.Length - 1] == 'в');
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem2_4(string[] arr)
        {
            Console.Write("\nМіста, назви яких закінчуються літерою \"в\": ");

            var newArr = arr.Where(e => e[e.Length - 1] == 'в');
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem2_3(string[] arr)
        {
            Console.Write("\nМіста, назви яких починаються з літери Х: ");

            var newArr = arr.Where(e => e[0] == 'Х');
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem2_2(string[] arr)
        {            
            Console.Write("Введіть кількість літер міста: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("\nМіста з заданною довжиною назви: ");
            var newArr = arr.Where(e => e.Length == size);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem2_1(string[] arr)
        {
            Console.Write("\nМасив міст: ");
            var newArr = arr.Where(e => e != null);
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_7(int[] arr)
        {
            Console.Write("\nЧисла, кратні восьми. Відсортовані за спаданням: ");
            var newArr7 = arr.Where(e => e % 8 == 0).OrderByDescending(e => e);
            foreach (var item in newArr7)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_6(int[] arr)
        {
            Console.Write("\nЧисла, кратні семи. Відсортовані за зростанням: ");
            var newArr6 = arr.Where(e => e % 7 == 0).OrderBy(e => e);
            foreach (var item in newArr6)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_5(int[] arr)
        {
            
            Console.Write("введіть перше значення діапазону: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("введіть друге значення діапазону: ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("\nЧисла в заданому діапазоні: ");
            var newArr5 = from p in arr
                          where p > value1 && p < value2
                          select p;
            foreach (var item in newArr5)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_4(int[] arr)
        {            
            Console.Write("\nВведіть мінімально допустиме значення: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("\nЗначення більші заданного: ");
            var newArr4 = from p in arr
                          where p > value
                          select p;
            foreach (var item in newArr4)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_3(int[] arr)
        {
            Console.Write("\nНепарні цілі числа: ");
            var newArr3 = from p in arr
                          where p % 2 != 0
                          select p;
            foreach (var item in newArr3)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_2(int[] arr)
        {
            Console.Write("\nПарні цілі числа: ");
            var newArr2 = from p in arr
                          where p % 2 == 0
                          select p;
            foreach (var item in newArr2)
            {
                Console.Write(item + " ");
            }
        }

        private static void Problem1_1(int[] arr)
        {
            Console.Write("\nКопіювання масиву: ");
            var newArr = from p in arr
                         select p;
            foreach (var item in newArr)
            {
                Console.Write(item + " ");
            };
        }
    }
}
