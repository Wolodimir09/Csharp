using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Years { get; set; }
        public string NameGroup { get; set; }

        public override string ToString()
        {
            return $"Імя - {FirstName}\n"+
                $"Фамілфя - {LastName}\n" +
                $"Вік - {Years}\n" +
                $"Група - {NameGroup}\n";
        }

    }
}
