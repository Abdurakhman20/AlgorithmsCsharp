using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T>? Next { get; set; }

        public ListNode(T data)
        {
            this.Data = data;
        }
    }
}
