using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LeetCodeLibrary
{
    public class ListNode2
    {
        public int val;
        public ListNode2 next;
        public ListNode2(int val = 0, ListNode2 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class MergeTwoSortedLists
    {
        public ListNode2 MergeTwoLists(ListNode2 list1, ListNode2 list2)
        {
            ListNode2 dummy = new ListNode2();
            ListNode2 current = dummy;

            while (list1 != null && list2 != null)
            {
                Console.WriteLine($"list1: {list1.val}, list2: {list2.val}");
                if (list1.val <= list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }

            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            return dummy.next;
        }
    }
}
