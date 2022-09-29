using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyExceptionCreditCart:ApplicationException
    {
        public DateTime TimeExceptionBancrot { get; private set; }
        public MyExceptionCreditCart() : base("Помилка банківської карти!!!")
        {
            TimeExceptionBancrot = DateTime.Now;
        }
    }
}
