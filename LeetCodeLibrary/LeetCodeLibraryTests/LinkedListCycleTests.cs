using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class LinkedListCycleTests
    {
        [Test]
        public void TestNoCycle()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            bool result = new LinkedListCycle().HasCycle(head);

            Assert.That(result, Is.False);
        }

        [Test]
        public void TestWithCycle()
        {
            ListNode head = new ListNode(1);
            ListNode second = new ListNode(2);
            ListNode third = new ListNode(3);

            head.next = second;
            second.next = third;
            third.next = second;

            bool result = new LinkedListCycle().HasCycle(head);
            Assert.That(result, Is.True);
        }

        [Test]
        public void TestEmptyList()
        {
            ListNode head = null;

            bool result = new LinkedListCycle().HasCycle(head);

            Assert.That(result, Is.False);
        }

        [Test]
        public void TestSingleNodeNoCycle()
        {
            ListNode head = new ListNode(1);

            bool result = new LinkedListCycle().HasCycle(head);

            Assert.That(result, Is.False);
        }

        [Test]
        public void TestSingleNodeWithCycle()
        {
            ListNode head = new ListNode(1);
            head.next = head;

            bool result = new LinkedListCycle().HasCycle(head);

            Assert.That(result, Is.True);
        }
    }
}
