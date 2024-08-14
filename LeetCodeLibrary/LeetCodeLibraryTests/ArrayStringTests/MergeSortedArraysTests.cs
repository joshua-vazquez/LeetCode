using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class MergeSortedArraysTests
    {
        [Test]
        public void Merge_TwoSortedArrays_MergesCorrectly()
        {
            // Arrange
            var solution = new MergeSortedArrays();
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            // Act
            solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }
        [Test]
        public void Merge_TwoSortedArrays_3()
        {
            // Arrange
            var solution = new MergeSortedArrays();
            int[] nums1 = [0];
            int m = 0;
            int[] nums2 = [1];
            int n = 1;
            int[] expected = [1];

            // Act
            solution.Merge(nums1, m, nums2, n);

            // Assert
            Assert.That(nums1, Is.EqualTo(expected));
        }
    }
}