using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ValidAnagramTests
    {
        private ValidAnagram validAnagram;

        [SetUp]
        public void SetUp()
        {
            validAnagram = new ValidAnagram();
        }

        [Test]
        [TestCase("anagram", "nagaram", true)]
        public void TestIsAnagram(string s, string t, bool expected)
        {
            bool result = validAnagram.IsAnagram(s, t);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        [TestCase("rat", "car", false)]
        public void TestIsNotAnagram(string s, string t, bool expected)
        {
            bool result = validAnagram.IsAnagram(s, t);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
