using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class MergeTwoSortedListsTests
    {
        [Test]
        public void MergeTwoLists_BothListsNonEmpty_ReturnsMergedSortedList()
        {
            // Arrange
            ListNode2 list1 = new ListNode2(1, new ListNode2(2, new ListNode2(4)));
            ListNode2 list2 = new ListNode2(1, new ListNode2(3, new ListNode2(4)));
            MergeTwoSortedLists merger = new MergeTwoSortedLists();

            // Act
            ListNode2 result = merger.MergeTwoLists(list1, list2);

            // Assert
            int[] expected = { 1, 1, 2, 3, 4, 4 };
            Assert.AreEqual(expected, ConvertToArray(result));
        }

        [Test]
        public void MergeTwoLists_OneListEmpty_ReturnsNonEmptyList()
        {
            // Arrange
            ListNode2 list1 = null;
            ListNode2 list2 = new ListNode2(0);
            MergeTwoSortedLists merger = new MergeTwoSortedLists();

            // Act
            ListNode2 result = merger.MergeTwoLists(list1, list2);

            // Assert
            int[] expected = { 0 };
            Assert.AreEqual(expected, ConvertToArray(result));
        }

        [Test]
        public void MergeTwoLists_BothListsEmpty_ReturnsEmptyList()
        {
            // Arrange
            ListNode2 list1 = null;
            ListNode2 list2 = null;
            MergeTwoSortedLists merger = new MergeTwoSortedLists();

            // Act
            ListNode2 result = merger.MergeTwoLists(list1, list2);

            // Assert
            Assert.IsNull(result);
        }

        private int[] ConvertToArray(ListNode2 node)
        {
            var list = new List<int>();
            while (node != null)
            {
                list.Add(node.val);
                node = node.next;
            }
            return list.ToArray();
        }
    }
}
