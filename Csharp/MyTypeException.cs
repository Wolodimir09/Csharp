using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyTypeException : ArgumentException
    {
        public override string Message => " Тип данних не відповідає потребам методу";
        public MyTypeException() { }
    }
}
