using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class JumpGame2Tests
    {
        [Test]
        public void BasicCaseTest()
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            int expected = 2;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SingleElementTest()
        {
            int[] nums = { 1 };
            int expected = 0;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TwoElementTest()
        {
            int[] nums = { 1, 2 };
            int expected = 1;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LargeJumpsTest()
        {
            int[] nums = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
            int expected = 1;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void MultipleJumpsTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expected = 4;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ZeroInMiddeleTest()
        {
            int[] nums = { 2, 3, 1, 0, 4 };
            int expected = 2;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LargeArrayTest()
        {
            int[] nums = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int expected = 35;

            int result = new JumpGame2().Jump(nums);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
