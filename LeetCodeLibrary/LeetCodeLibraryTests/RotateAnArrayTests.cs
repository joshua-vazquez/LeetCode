using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class RotateAnArrayTests
    {
        [Test]
        public void BasicRotationTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            int[] expected = { 5, 6, 7, 1, 2, 3, 4 };

            new RotateAnArray().Rotate(nums, k);

            Assert.That(nums, Is.EqualTo(expected));
        }

        [Test]
        public void NoRotationTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 0;
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };

            new RotateAnArray().Rotate(nums, k);
        }

        [Test]
        public void FullRotationTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 7;
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };

            new RotateAnArray().Rotate(nums, k);
        }

        [Test]
        public void LargeRotationTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 10;
            int[] expected = { 5, 6, 7, 1, 2, 3, 4 };

            new RotateAnArray().Rotate(nums, k);

            Assert.That(nums, Is.EqualTo(expected));
        }

        [Test]
        public void SingleElementArrayTest()
        {
            int[] nums = { 1 };
            int k = 1;
            int[] expected = { 1 };

            new RotateAnArray().Rotate(nums, k);

            Assert.That(nums, Is.EqualTo(expected));
        }

        [Test]
        public void TwoElementArrayTest()
        {
            int[] nums = { 1, 2 };
            int k = 1;
            int[] expected = { 2, 1 };

            new RotateAnArray().Rotate(nums, k);

            Assert.That(nums, Is.EqualTo(expected));
        }

        [Test]
        public void LargeArrayTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 4;
            int[] expected = { 7, 8, 9, 10, 1, 2, 3, 4, 5, 6 };

            new RotateAnArray().Rotate(nums, k);

            Assert.That(nums, Is.EqualTo(expected));
        }
    }
}
