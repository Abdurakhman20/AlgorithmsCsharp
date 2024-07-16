using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DataStructures
{
    public class Stack<T>
    {
        static readonly int MAX = 1000;
        int top;
        readonly T[] stack = new T[MAX];

        public Stack()
        {
            top = -1;
        }

        public bool Push(T data)
        {
            if(top >= MAX)
            {
                throw new Exception("Exeption: Stack overflow");
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        public T Pop()
        {
            if(top < 0)
            {
                throw new Exception("Exeption: Stack is empty");
            }
            else
            {
                T value = stack[top--];
                return value;
            }
        }

        public T Peek()
        {
            if(top < 0)
            {
                throw new Exception("Exeption: Stack is empty");
            }
            else
            {
                return stack[top];
            }
        }

        
        override public string ToString()
        {
            if (top < 0)
            {
                return "Stack is empty";
            }
            else
            {
                var builder = new StringBuilder();
                builder.Append("Stack items: ");

                for (int i = top; i >= 0; i--)
                {
                    builder.Append(stack[i] + " ");
                }

                return builder.ToString();
            }
        }

    }
}
