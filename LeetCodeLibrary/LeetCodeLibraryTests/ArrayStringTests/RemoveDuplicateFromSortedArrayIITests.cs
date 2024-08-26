using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class RemoveDuplicateFromSortedArrayIITests
    {
        [Test]
        public void BasicTest()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int expected = 5;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void NoDuplicatesTest()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int expected = 5;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void AllElementsAreTheSameTest()
        {
            int[] nums = { 2, 2, 2, 2, 2 };
            int expected = 2;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MixedDuplicatesTest()
        {
            int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            int expected = 7;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MinimumLengthArrayTest()
        {
            int[] nums = { 1 };
            int expected = 1;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TwoElementsArrayTest()
        {
            int[] nums = { 1, 1 };
            int expected = 2;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LargeArrayTest()
        {
            int[] nums = { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5 };
            int expected = 10;

            int result = new RemoveDuplicateFromSortedArrayII().RemoveDuplicates(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
