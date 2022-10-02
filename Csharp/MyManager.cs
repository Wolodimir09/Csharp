using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyManager
    {
        private ListRecipes listRecipes = new ListRecipes();
        public void Menu()
        {
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
                    SwitchManagerMenu(key);
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
        private void SwitchManagerMenu(ConsoleKey key) // Реалізація меню
        {

            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        Console.Write("\tВведіть наступні данні: ");
                        listRecipes.Add();
                        Console.WriteLine("Рецепт додано");
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        
                    }
                    break;
                case ConsoleKey.D3:
                    {
                       
                    } break;
                case ConsoleKey.D4:
                    {
                        SearchRecipe();
                    }
                    break;
            }
        }

        private void SearchRecipe()
        {            
            ConsoleKey key;
            do
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("\tВиберіть параметр для пошуку рецептів:");
                Console.WriteLine("\n\t- Нажміть 1, щоб знайти за назвою рецепта;" +
                                    "\n\t- Нажміть 2, щоб знайти за назвою кухні;" +                                    
                                    "\n\t- Нажміть Esc для повернення до попереднього меню");
                Console.Write("\tЗробіть Ваш вибір: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.Clear();
                key = keyInfo.Key;
                try
                {
                    SwitchSearchMenu(key);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine("\t" + ex.Message);
                }

            } while (key != ConsoleKey.Escape);
        }

        private void SwitchSearchMenu(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine(listRecipes.SearchName()); 
                    } break;
                case ConsoleKey.D2:
                    {
                        
                    } break;                
                case ConsoleKey.D3:
                    {
                        SearchRecipe();
                    } break;
            }
        }
    }
}
