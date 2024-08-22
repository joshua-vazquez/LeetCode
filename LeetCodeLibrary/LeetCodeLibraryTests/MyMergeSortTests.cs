using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class MyMergeSortTests
    {
        [Test]
        public void TestEmptyArray()
        {
            int[] arr = new int[0];
            int[] expected = { };

            MyMergeSort.MergeSort(arr);

            Assert.That(arr, Is.EqualTo(expected));
        }

        [Test]
        public void TestSingleElementArray()
        {
            int[] arr = { 1 };
            int[] expected = { 1 };

            MyMergeSort.MergeSort(arr);

            Assert.That(arr, Is.EqualTo(expected));
        }

        [Test]
        public void TestAlreadySortedArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            MyMergeSort.MergeSort(arr);

            Assert.That(arr, Is.EqualTo(expected));
        }

        [Test]
        public void TestReverseSortedArray()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            MyMergeSort.MergeSort(arr);

            Assert.That(arr, Is.EqualTo(expected));
        }

        [Test]
        public void TestUnsortedArray()
        {
            int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
            int[] expected = { 3, 9, 10, 27, 38, 43, 82 };

            MyMergeSort.MergeSort(arr);

            Assert.That(arr, Is.EqualTo(expected));

        }

        [Test]
        public void TestArrayWithDuplicates()
        {
            int[] arr = { 5, 1, 3, 5, 2, 5, 4 };
            int[] expected = { 1, 2, 3, 4, 5, 5, 5 };

            MyMergeSort.MergeSort(arr);

            Assert.That(arr, Is.EqualTo(expected));
        }
    }
}
