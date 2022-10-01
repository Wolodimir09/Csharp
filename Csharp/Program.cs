using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        public static event Func<Backpack, string, double,double, Backpack> addContentBackpack;
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.Unicode;
            Console.InputEncoding=Encoding.Unicode;
            
            Backpack backpack = new Backpack("Сірий", "Sport run: Adidas", "Синтетика", 15, 7.5);
            do
            {
                Console.Clear();
                try
                {                    
                    Console.WriteLine(backpack);
                    AddContentBackpack(backpack);
                }
                catch (MyBackpackException my)
                {
                    Console.WriteLine(my.Message);
                    Console.ReadKey(true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey(true);
                }
            } while (true);
            
        }       
        
        static Backpack AddContentBackpack(Backpack backpack)
        {
            addContentBackpack = delegate (Backpack backpack1, string nameObject,double weight, double volume)
            {
                if (backpack1.Volume - volume < 0 || backpack1.Weight - weight<0)
                {
                    throw new MyBackpackException("\tРюкзак переповнений!!!");
                }
                backpack1._content.Add(nameObject, volume);
                backpack1.Volume -= volume;
                backpack1.Weight -=weight;
                return backpack1;
            };
            Console.Write("Введіть назву предмета: ");
            string nameNewObject = Console.ReadLine();
            Console.Write("Введіть вагу предмета: ");
            double weightObject = double.Parse(Console.ReadLine());
            Console.Write("Введіть об'єм предмета: ");
            double volumeObject = double.Parse(Console.ReadLine());
            
            addContentBackpack(backpack, nameNewObject, weightObject, volumeObject);
            return backpack;
        }
    }
}
