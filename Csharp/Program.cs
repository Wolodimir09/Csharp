using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Program
    {
        public delegate void MessageDel(string messange);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            
            List<User> users = new List<User>() {
                new User()
                {
                    Name = "Павло",
                    Date = new DateTime(1988,02,04),
                },
                new User()
                {
                    Name = "Михайло",
                    Date = new DateTime(1993,10,27),
                },
                new User()
                {
                    Name = "Тарас",
                    Date = new DateTime(2001,09,13),
                },
                new User()
                {
                    Name = "Роман",
                    Date = new DateTime(2010,12,31),
                },
            };
            Message message = new Message();
            MessageDel messageDel = message.MessageString;
            foreach (User item in users)
            {
                messageDel(item.ToString() + "\nІсторія активності користувача на сайті");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
