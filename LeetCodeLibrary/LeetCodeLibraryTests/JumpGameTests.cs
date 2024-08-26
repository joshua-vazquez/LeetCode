using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class JumpGameTests
    {
        [Test]
        public void BasicTest()
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            bool result = new JumpGame().CanJump(nums);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CannotReachEndTest()
        {
            int[] nums = { 3, 2, 1, 0, 4 };
            bool result = new JumpGame().CanJump(nums);
            Assert.That(result, Is.False);
        }

        [Test]
        public void SingleElementTest()
        {
            int[] nums = { 0 };
            bool result = new JumpGame().CanJump(nums);
            Assert.That(result, Is.True);
        }

        [Test]
        public void LargeJumpTest()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool result = new JumpGame().CanJump(nums);
            Assert.That(result, Is.True);
        }
    }
}