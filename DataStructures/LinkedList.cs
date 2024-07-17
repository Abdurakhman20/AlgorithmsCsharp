using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures 
{ 
    public class LinkedList<T>
    {
        public ListNode<T>? First { get; private set; }
        public ListNode<T>? Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList()
        {
            this.First = null;
            this.Last = null;
        }

        public void AddFirst(ListNode<T> node)
        {
            if(this.First == null)
            {
                this.First = node;
                this.Last = node;
            }
            else
            {
                node.Next = this.First;
                this.First = node;
            }

            this.Count++;
        }

        public void AddAfter(ListNode<T> node,  ListNode<T> existingNode)
        {
            if(this.Last == existingNode)
            {
                this.Last = node;
            }

            node.Next = existingNode.Next;
            existingNode.Next = node;
            this.Count++;
        }

        public ListNode<T> Find(T targetData)
        {
            ListNode<T>? current = this?.First;

            while (current != null && !current.Data.Equals(targetData))
            {
                current = current.Next;
            }

            return current;
        }

        public void RemoveFirst()
        {
            if(this.First == null || this.Count == 0)
            {
                return;
            }

            this.First = this.First.Next;
            this.Count--;
        }

        public void Traverse()
        {
            ListNode<T>? node = this.First;

            while(node?.Next != null)
            {
                node = node.Next;
            }
        }
    }
}
