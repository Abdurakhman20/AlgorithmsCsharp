using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
    public class Queue<T>
    {
        private T[] queue;

        private int head = 0;
        private int tail = 0;
        private int size;
        public Queue(int size = 10) 
        {
            this.size = size;
            queue = new T[size];
        }

        public void Enqueue(T element)
        {
            if(tail > size)
            {
                throw new Exception("Queue overflow");
            }

            queue[tail] = element;

            if(tail == size)
            {
                tail = 1;
            }
            else
            {
                tail++;
            }
        }

        public T Dequeue()
        {
            T element = queue[head];

            if(head == size)
            {
                head = 1;
            } 
            else
            {
                head++;
            }

            return element;
        }
    }
}
