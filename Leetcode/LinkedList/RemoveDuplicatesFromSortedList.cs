using Leetcode.Utils;

namespace Leetcode.LinkedList
{
    public class RemoveDuplicatesFromSortedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) 
                return null;

            if (head.next == null) 
                return head;

            ListNode current = head;

            while (current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }

            }

            return head;
        }

    }
}
