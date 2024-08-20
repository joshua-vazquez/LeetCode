using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeLibrary
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
