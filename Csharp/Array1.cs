using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Array
    {
        private int[] arr;
        public Array(params int[] arr)
        {
            this.arr = arr;
        }
        public void Show()
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }
}
