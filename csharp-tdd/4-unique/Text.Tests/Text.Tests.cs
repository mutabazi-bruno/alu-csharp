using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            int result = Str.UniqueChar("abcdef");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_MiddleCharUnique_ReturnsIndex()
        {
            int result = Str.UniqueChar("aabbcdd");
            Assert.AreEqual(4, result);
        }

        [Test]
        public void UniqueChar_LastCharUnique_ReturnsLastIndex()
        {
            int result = Str.UniqueChar("aabbccdde");
            Assert.AreEqual(8, result);
        }

        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsNegativeOne()
        {
            int result = Str.UniqueChar("aabbcc");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            int result = Str.UniqueChar("");
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            int result = Str.UniqueChar("a");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_AllUnique_ReturnsZero()
        {
            int result = Str.UniqueChar("abcdefg");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_NullString_ReturnsNegativeOne()
        {
            int result = Str.UniqueChar(null);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_ComplexString_ReturnsCorrectIndex()
        {
            int result = Str.UniqueChar("leetcode");
            Assert.AreEqual(0, result);
        }
    }
}
