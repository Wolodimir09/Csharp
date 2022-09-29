using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public delegate Func<string, string> mesageDel(string mesage);
    internal class Person
    {         
        public event mesageDel mesageDel;
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        private CreditCard card = null;

        public Person(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            card = new CreditCard(firstName,lastName,middleName);
        }
    }
}
