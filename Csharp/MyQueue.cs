using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class MyQueue<T>
    {
        List<T> queue;
        public int count { get; private set; }

        public MyQueue()
        {
            queue = new List<T>();
        }
        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T dequeue = queue[0];
            queue.Remove(queue[0]);
            count--;
            return dequeue;
        }
        public T Peek()
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            return queue[0];
        }
        public void Enqueue(T value)
        {
            queue.Add(value);
            count++;
        }
        public override string ToString()
        {
            string stQueue = " ";
            foreach (var item in queue)
            {
                stQueue += item.ToString() + " ";
            }
            return stQueue;
        }
    }
}
