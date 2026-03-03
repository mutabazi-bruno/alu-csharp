using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            int result = Str.CamelCase("hello");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            int result = Str.CamelCase("helloWorld");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("thisIsACamelCaseString");
            Assert.AreEqual(6, result);
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            int result = Str.CamelCase("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            int result = Str.CamelCase(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_ThreeWords_ReturnsThree()
        {
            int result = Str.CamelCase("saveChangesInTheEditor");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CamelCase_SingleChar_ReturnsOne()
        {
            int result = Str.CamelCase("a");
            Assert.AreEqual(1, result);
        }

        [Test]
        public void CamelCase_ManyCapitals_ReturnsCorrectCount()
        {
            int result = Str.CamelCase("oneTwoThreeFourFive");
            Assert.AreEqual(5, result);
        }
    }
}
