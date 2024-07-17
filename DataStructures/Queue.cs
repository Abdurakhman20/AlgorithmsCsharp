using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Queue<T>
    {
        private T[] queue;
        private int head = 0;
        private int tail = 0;
        private int count = 0; 
        private readonly int size;

        public Queue(int size = 10)
        {
            this.size = size;
            queue = new T[size];
        }

        public void Enqueue(T element)
        {
            if (count == size)
            {
                throw new Exception("Queue overflow");
            }

            queue[tail] = element;
            tail = (tail + 1) % size;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new Exception("Queue underflow");
            }

            T element = queue[head];
            head = (head + 1) % size;
            count--;
            return element;
        }

        public override string ToString()
        {
            if (count == 0)
            {
                return "Queue is empty";
            }

            var builder = new StringBuilder();
            builder.Append("Queue items: ");

            for (int i = 0; i < count; i++)
            {
                int index = (head + i) % size;
                builder.Append(queue[index] + " ");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
