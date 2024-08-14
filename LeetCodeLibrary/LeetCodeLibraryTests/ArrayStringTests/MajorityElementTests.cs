using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class MajorityElementTests
    {
        [Test]
        public void MajorityElement_SimpleCase_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new MajorityElement();
            int[] nums = { 3, 2, 3 };
            int expected = 3;

            // Act
            int result = solution.FindMajorityElement(nums);

            // Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void MajorityElement_MultipleOccurrences_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new MajorityElement();
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            int expected = 2;

            // Act
            int result = solution.FindMajorityElement(nums);

            // Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void MajorityElement_SingleElement_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new MajorityElement();
            int[] nums = { 1 };
            int expected = 1;

            // Act
            int result = solution.FindMajorityElement(nums);

            // Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void MajorityElement_AllSameElements_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new MajorityElement();
            int[] nums = { 4, 4, 4, 4 };
            int expected = 4;

            // Act
            int result = solution.FindMajorityElement(nums);

            // Assert
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void MajorityElement_LargeArray_ReturnsCorrectResult()
        {
            // Arrange
            var solution = new MajorityElement();
            int[] nums = { 1, 1, 1, 2, 2, 1, 1 };
            int expected = 1;

            // Act
            int result = solution.FindMajorityElement(nums);

            // Assert
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
