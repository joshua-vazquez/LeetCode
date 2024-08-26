using NUnit.Framework;
using LeetCodeLibrary;

namespace LeetCodeLibraryTests
{
    [TestFixture]
    public class ReverseBitsTests
    {
        [Test]
        public void Test1()
        {
            uint n = 43261596;
            uint expected = 964176192;

            uint result = new ReverseBits().ReverseBitsMethod(n);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test2()
        {
            uint n = 3221225471;
            uint expected = 4294967293;

            uint result = new ReverseBits().ReverseBitsMethod(n);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
