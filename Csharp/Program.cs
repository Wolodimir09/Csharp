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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            MyQueue<int> queue = new MyQueue<int>();
            Console.WriteLine("\tВАС ВІТАЄ ПРОГРАММА \"QUEUE\"");
            MyQueueMenu(queue);
            Console.WriteLine("\n\tДО НОВИХ ЗУСТРІЧЕЙ!!!");
        }
        private static void MyQueueMenu(MyQueue<int> queue)
        {
            ConsoleKey key = ConsoleKey.Escape;

            do
            {
                try
                {
                    Console.WriteLine("\t-----------------------------------------------------");
                    Console.WriteLine("\tСкористайтесь данним меню для вибору необхідних операцій:");
                    Console.WriteLine("\n\t- Нажміть 1 для перегляду Вашої черги;" +
                                      "\n\t- Нажміть 2 , щоб добавити новий цілочисельний елемент;" +
                                      "\n\t- Нажміть 3 , щоб видалити перший елемент із його переглядом;" +
                                      "\n\t- Нажміть 4 , щоб переглянути перший елемент;" +
                                      "\n\t- Нажміть 5 , щоб переглянути кількість елементів;" +
                                      "\n\t- Нажміть Esc для виходу");
                    Console.Write("\tЗробіть Ваш вибір: ");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    Console.Clear();
                    key = keyInfo.Key;
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            {
                                Console.WriteLine("\tВаш Queue: " + queue);
                            }
                            break;
                        case ConsoleKey.D2:
                            {
                                Console.Write("\tВведіть цілочисельне значення нового елементу: ");
                                queue.Enqueue(int.Parse(Console.ReadLine()));
                            }
                            break;
                        case ConsoleKey.D3:
                            {
                                Console.WriteLine("\tУспішно видаленно наступний елемент: " + queue.Dequeue());

                            }
                            break;
                        case ConsoleKey.D4:
                            {
                                Console.WriteLine("\tПерший елемент: " + queue.Peek());
                            }
                            break;
                        case ConsoleKey.D5:
                            {
                                Console.WriteLine("\tКількість елементів у Queue: " + queue.count);
                            }
                            break;
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("\tПустий Queue!!!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\t" + ex.Message);
                    Console.WriteLine("\tСпробуйте ще!");
                }

            } while (key != ConsoleKey.Escape);
        }
    }
}
