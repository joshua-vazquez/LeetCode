using NUnit.Framework;
using LeetCodeLibrary;
using System.Globalization;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class LongestCommonPrefixTests
    {
        private LongestCommonPrefix longestCommonPrefix;

        [SetUp]
        public void SetUp()
        {
            longestCommonPrefix = new LongestCommonPrefix();
        }

        [Test]
        public void TestCommonPrefix()
        {
            string[] strs = { "flower", "flow", "flight" };
            
            string expected = "fl";
            string result = longestCommonPrefix.FindLongestCommonPrefix(strs);
            
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestNoCommonPrefix()
        {
            string[] strs = { "dog", "racecar", "car" };
            string expected = "";

            string result = longestCommonPrefix.FindLongestCommonPrefix(strs);
            
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestEmptyArray()
        {
            string[] strs = { };
            string expected = "";

            string result = longestCommonPrefix.FindLongestCommonPrefix(strs);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestSingleString()
        {
            string[] strs = { "single" };
            string expected = "single";

            string result = longestCommonPrefix.FindLongestCommonPrefix(strs);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestAllStringsIdentical()
        {
            string[] strs = { "test", "test", "test" };
            string expected = "test";

            string result = longestCommonPrefix.FindLongestCommonPrefix(strs);

            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void TestMixedLengthStrings()
        {
            string[] strs = { "ab", "a" };
            string expected = "a";

            string result = longestCommonPrefix.FindLongestCommonPrefix(strs);

            Assert.That(expected, Is.EqualTo(result));
        }
    }
}