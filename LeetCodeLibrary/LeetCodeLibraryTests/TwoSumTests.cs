using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class TwoSumTests
    {
        [Test]
        public void Test1()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] expected = { 0, 1 };
            int[] result = new TwoSum().FindSum(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void NegativeNumbersTest()
        {
            int[] nums = { -1, -2, -3, -4, -5 };
            int target = -8;

            int[] expected = { 2, 4 };
            int[] result = new TwoSum().FindSum(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestWithZeros()
        {
            int[] nums = { 0, 4, 3, 0 };
            int target = 0;

            int[] expected = { 0, 3 };
            int[] result = new TwoSum().FindSum(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void LargeNumbersTest()
        {
            int[] nums = { 1000000000, 2000000000, -1500000000 };
            int target = 500000000;

            int[] expected = { 1, 2 };
            int[] result = new TwoSum().FindSum(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void NoSolutionTest()
        {
            int[] nums = { 1, 2, 3, 4 };
            int target = 10;

            int[] expected = new int[0];
            int[] result = new TwoSum().FindSum(nums, target);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
