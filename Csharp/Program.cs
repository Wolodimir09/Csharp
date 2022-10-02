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
            
            Console.WriteLine("\tВАС ВІТАЄ ПРОГРАММА \"КНИГА РЕЦЕПТІВ\"");
            ConsoleKey key;
            do
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("\tСкористайтесь данним меню для вибору необхідних операцій:");
                Console.WriteLine("\n\t- Нажміть 1, щоб додати новий рецепт;" +
                                    "\n\t- Нажміть 2, щоб видалити рецепт;" +
                                    "\n\t- Нажміть 3, щоб змінити рецепт;" +
                                    "\n\t- Нажміть 4, щоб шукати рецепт;" +
                                    "\n\t- Нажміть Esc для виходу");
                Console.Write("\tЗробіть Ваш вибір: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();
                key = keyInfo.Key;
                try
                {
                    SwitchMenu(key);
                }
                catch (MyExceptionCreditCart my)
                {
                    Console.WriteLine(bank.Check(my.Message));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("\t" + ex.Message);
                }

            } while (key != ConsoleKey.Escape);
            Console.WriteLine("\n\tДО НОВИХ ЗУСТРІЧЕЙ!!!");


            Console.ReadKey(true);
        }

        private static void SwitchMenu(ConsoleKey key) // Реалізація менюшки
        {

            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("\tВведіть суму для поповнення: ");
                        double money = double.Parse(Console.ReadLine());
                        Console.Write($"\tВведіть ваш пін-код: ");
                        int pin = int.Parse(Console.ReadLine());
                        Console.WriteLine(bank.Check(petro.Card.Refill(pin, money)));
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        Console.Write("\tВведіть суму для зняття коштів: ");
                        double money = double.Parse(Console.ReadLine());
                        Console.Write($"\tВведіть ваш пін-код: ");
                        int pin = int.Parse(Console.ReadLine());
                        Console.WriteLine(bank.Check(petro.Card.StartCreditMoney(money) +
                                                        petro.Card.withdrawalOfFunds(pin, money)));
                    }
                    break;
                case ConsoleKey.D3:
                    {
                        Console.WriteLine(bank.Check(petro.Card.AlterationPinCod()));
                    }
                    break;
            }
        }
    }
}
