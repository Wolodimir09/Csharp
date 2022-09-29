using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public delegate string mesageDel(string mesage);
    internal class Person
    {           
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public CreditCard Card { get; private set; }

        public Person(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Card = new CreditCard(firstName,lastName,middleName);
        }

        public string Message(string message) 
        {
            Console.WriteLine("---------------------------------------------------------");
            return $"\t{FirstName}! Вам нове повідомлення: \n\t{message}\n\t\t{DateTime.Now}\n";            
        }
    }
}
