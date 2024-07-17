namespace Leetcode.LinkedList
{
    public class RemoveDuplicatesFromSortedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

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
