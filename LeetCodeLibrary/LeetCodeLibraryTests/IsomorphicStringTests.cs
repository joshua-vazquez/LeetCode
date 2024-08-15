using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class IsomorphicStringTests
    {
        private IsomorphicString isomorphicString;

        [SetUp]
        public void SetUp()
        {
            isomorphicString = new IsomorphicString();
        }

        [Test]
        [TestCase("egg", "add", true)]
        [TestCase("paper", "title", true)]
        public void TestIsIsomorphic(string s, string t, bool expected)
        {
            bool result = isomorphicString.IsIsomorphic(s, t);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        [TestCase("foo", "bar", false)]
        [TestCase("ab", "aa", false)]
        public void TestIsIsomorphicFalse(string s, string t, bool expected)
        {
            bool result = isomorphicString.IsIsomorphic(s, t);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        [TestCase("b", "a", true)]
        [TestCase("a", "a", true)]
        public void TestIsIsomorphicSingleChar(string s, string t, bool expected)
        {
            bool result = isomorphicString.IsIsomorphic(s, t);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
