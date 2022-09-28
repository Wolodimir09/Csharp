using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public delegate int[] MyArrayDel(int[] arr);
    internal static class MyArray
    {
        
        // Метод для отримання усіх парних чисел у масиві
        public static int[] EvenNumbers(int[] arr) => arr.Where(x=>x%2==0).ToArray();
        // Метод для отримання усіх непарних чисел у масиві
        public static int[] AnOddNumbers(int[] arr) => arr.Where(x => x % 2 != 0).ToArray();
        // Метод для отримання усіх простих чисел у масиві
        public static int[] Primes(int[] arr) {
            List<int> list = new List<int>();
            int control;
            for (int i = 0; i < arr.Length; i++)
            {
                control = 0;
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (arr[i]%j==0)
                    {
                        control++;
                    }
                }
                if (control == 2)
                {
                    list.Add(arr[i]);
                }
            }
            return list.ToArray();
        }
        // Метод для отримання усіх чисел Фібоначчі в масиві
        public static int[] FibonacciNumbers(int[] arr)
        {
            List<int> list = new List<int>() { 0,1};
            List<int> fibonacciNumbers = new List<int>(); 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (arr[i] > list[list.Count-1])
                    {
                        list.Add(list[list.Count - 2] + list[list.Count - 1]);
                    }
                    else if(arr[i] == list.FirstOrDefault(a => a == arr[i]))
                    {
                        fibonacciNumbers.Add(arr[i]);
                        break;
                    }
                    else
                    {                        
                        break;
                    }
                    
                }
            }
            return fibonacciNumbers.ToArray();
        }
    }
}
