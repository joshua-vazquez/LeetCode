using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class WordPatternTests
    {
        private WordPattern wordPattern;

        [SetUp]
        public void SetUp()
        {
            wordPattern = new WordPattern();
        }

        [Test]
        [TestCase("abba", "dog cat cat dog", true)]
        [TestCase("lololol", "cat dog cat dog cat dog cat", true)]
        public void TestIsThereAPaternTrue (string pattern, string s, bool expected)
        {
            bool result = wordPattern.IsThereAPAttern(pattern, s);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        [TestCase("abba", "dog cat cat fish", false)]
        [TestCase("lololol", "cat dog cat dog cat fish", false)]
        public void TestIsThereAPaternFalse(string pattern, string s, bool expected)
        {
            bool result = wordPattern.IsThereAPAttern(pattern, s);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
