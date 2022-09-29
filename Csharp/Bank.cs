using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Bank // Диспетчер
    {
        public event mesageDel mesage;
        public string Check(string infoOperation)
        {
            if (mesage!=null)
            {
                return mesage(infoOperation);
            }
            return " ";
        }
    }
}
