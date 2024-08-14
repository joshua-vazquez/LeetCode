using LeetCodeLibrary;
using NUnit.Framework;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class RemoveDuplicateFromSortedArrayTests
    {
        [Test]
        public void RemoveDuplicates_RemovesDuplicates_Correctly()
        {
            // Arrange
            var solution = new RemoveDuplicateFromSortedArray();
            int[] nums1 = { 1, 1, 2 };
            int[] expected1 = { 1, 2 };
            int expectedLength1 = 2;

            int[] nums2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] expected2 = { 0, 1, 2, 3, 4 };
            int expectedLength2 = 5;

            // Act
            int resultLength1 = solution.RemoveDuplicates(nums1);
            int resultLength2 = solution.RemoveDuplicates(nums2);

            // Assert
            Assert.That(expectedLength1, Is.EqualTo(resultLength1));
            for (int i = 0; i < expectedLength1; i++)
            {
                Assert.That(expected1[i], Is.EqualTo(nums1[i]));
            }

            Assert.That(expectedLength2, Is.EqualTo(resultLength2));
            for (int i = 0; i < expectedLength2; i++)
            {
                Assert.That(expected2[i], Is.EqualTo(nums2[i]));
            }
        }

        [Test]
        public void RemoveDuplicates_EmptyArray_ReturnsZero()
        {
            // Arrange
            var solution = new RemoveDuplicateFromSortedArray();
            int[] nums = { };
            int expectedLength = 0;

            // Act
            int resultLength = solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(expectedLength, Is.EqualTo(resultLength));
        }

        [Test]
        public void RemoveDuplicates_SingleElementArray_ReturnsOne()
        {
            // Arrange
            var solution = new RemoveDuplicateFromSortedArray();
            int[] nums = { 1 };
            int[] expected = { 1 };
            int expectedLength = 1;

            // Act
            int resultLength = solution.RemoveDuplicates(nums);

            // Assert
            Assert.That(expectedLength, Is.EqualTo(resultLength));
            Assert.That(expected[0], Is.EqualTo(nums[0]));
        }
    }
}
