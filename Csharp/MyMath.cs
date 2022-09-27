using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal static class MyMath
    {
        public static bool Pair(int value) => value % 2 == 0;
        public static bool Unmathed(int value) => !(value % 2 == 0);
        public static bool PrimeNumber(int value)
        {
            int count = 0;
            for (int i = 1; i <= value; i++)
            {
                if (value % i == 0)
                {
                    count++;
                }
            }
            return count == 2;
        }
        public static bool FibonachiBool(int value)
        {
            int countNumbersValue = value.ToString().Length;

            int valueFirst = 0, valueNext = 1, valueTemporary;
            string control = "1";
            if (countNumbersValue > 6)
            {
                countNumbersValue = (countNumbersValue - 6) / 2 + 6;
            }
            for (int i = 1; i < countNumbersValue; i++)
            {
                valueTemporary = valueNext;
                valueNext += valueFirst;
                valueFirst = valueTemporary;
                control += valueNext.ToString();
            }
            return value.ToString() == control;
        }
    }
}
