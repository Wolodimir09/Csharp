using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class User
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; private set; }
        public static int CountUser { get; private set; } = 0;
        public User()
        {
            CountUser++;
            UserId = CountUser;
        }

        public override string ToString()
        {
            return $"Ім'я користувача: \t{Name}\nДата реєстрації: \t{Date.ToShortDateString()}\n" +
                    $"Користувацький ID: \t{UserId}";
        }
    }
}
