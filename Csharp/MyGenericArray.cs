using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyGenericArray<T> where T : struct
    {
        private T[] array;
        private string[] tipes = new string[] { "Int32", "Double", "Byte" };

        public MyGenericArray(params T[] arr)
        {
            array = arr;
        }

        public T MaxValue()
        {
            return array.Max();
        }
        public T MinValue()
        {
            return array.Min();
        }
        public override string ToString()
        {
            string rezult = null;
            foreach (var item in array)
                rezult += $"{item}".PadRight(10);
            return rezult;
        }

        public double Sum()
        {
            int sumInt = 0;
            double sumDouble = 0;
            byte sumByte = 0;
            if (tipes.Contains(array[0].GetType().Name.ToString()))
            {
                foreach (var item in array)
                {
                    switch (array[0].GetType().Name.ToString())
                    {
                        case "Int32":
                            {
                                sumInt += Convert.ToInt32(item);
                                break;
                            }
                        case "Double":
                            {
                                sumDouble += Convert.ToDouble(item);
                                break;
                            }
                        case "Byte":
                            {
                                sumByte += Convert.ToByte(item);
                                break;
                            }

                    }
                }
                sumDouble += sumByte + sumInt;
            }
            else
            {
                throw new MyTypeException();
            }
            return sumDouble;
        }
    }
}

