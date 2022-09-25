using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyStack<T>
    {
        List<T> stack;
        public int count { get; private set; }

        public MyStack()
        {
            stack = new List<T>();
        }
        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T pop = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            count--;
            return pop;
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T pop = stack[stack.Count - 1];
            return pop;
        }
        public void Push(T value)
        {
            stack.Add(value);
            count++;
        }
        public override string ToString()
        {
            string stStack = " ";
            for (int i = count - 1; i >= 0; i--)
            {
                stStack += stack[i].ToString() + " ";
            }
            return stStack;
        }
    }
}
