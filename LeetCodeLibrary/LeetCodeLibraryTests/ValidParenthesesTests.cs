using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ValidParenthesesTests
    {
        [Test]
        [TestCase("()", true)]
        [TestCase("()[]{}", true)]
        [TestCase("(]", false)]
        [TestCase("([)]", false)]
        [TestCase("{[]}", true)]
        [TestCase("]", false)]
        [TestCase("(", false)]
        public void TestIsValid(string s, bool expected)
        {
            bool result = new ValidParentheses().IsValid(s);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}
