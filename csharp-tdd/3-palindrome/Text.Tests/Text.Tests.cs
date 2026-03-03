using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsPalindrome_Racecar_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("Racecar");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_Level_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("level");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_Panama_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("A man, a plan, a canal: Panama.");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            bool result = Str.IsPalindrome("hello");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsPalindrome_SingleChar_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("a");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_WithSpaces_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("race car");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_WithNumbers_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("12321");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome(null);
            Assert.AreEqual(true, result);
        }
    }
}
