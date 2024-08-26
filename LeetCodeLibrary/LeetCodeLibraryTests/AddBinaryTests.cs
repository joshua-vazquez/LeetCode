using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class AddBinaryTests
    {
        [Test]
        [TestCase("11", "1", "100")]
        [TestCase("1010", "1011", "10101")]
        [TestCase("0", "0", "0")]
        [TestCase("1", "0", "1")]
        [TestCase("0", "1", "1")]
        [TestCase( "", "1", "1")]
        public void TestAddBinary(string a, string b, string expected)
        {
            string result = new AddBinary().AddTheBinary(a, b);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
