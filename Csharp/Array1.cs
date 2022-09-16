using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Array : IOutput, IMath, ISort, ICalc, IOutput2
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

        public int Max()
        {
            return arr.Max();
        }

        public int Min()
        {
            return arr.Min();
        }
        public float Avg()
        {
            return (float)arr.Sum() / arr.Length;
        }

        public bool Search(int valueToSearch)
        {
            return (System.Array.BinarySearch(arr, valueToSearch) >= 0) ? true : false;
        }

        public void SortAsc()
        {
            System.Array.Sort(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true)
                SortAsc();
            else
                SortDesc();
        }

        public void SortDesc()
        {
            SortAsc();
            System.Array.Reverse(arr);
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var item in arr)
                if (item < valueToCompare)
                    count++;
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var item in arr)
                if (item > valueToCompare)
                    count++;
            return count;
        }

        public void ShowEven()
        {
            foreach (var item in arr)
                if (item % 2 == 0)
                    Console.Write(item + " ");
        }

        public void ShowOdd()
        {
            foreach (var item in arr)
                if (item % 2 != 0)
                    Console.Write(item + " ");
        }
    }
}
