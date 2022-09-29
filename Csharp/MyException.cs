using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyExceptionCreditCart:ApplicationException
    {
        public DateTime time { get; private set; }        
         
        public MyExceptionCreditCart(string message) : base(message)
        {
            time = DateTime.Now;            
        }        
    }
}
