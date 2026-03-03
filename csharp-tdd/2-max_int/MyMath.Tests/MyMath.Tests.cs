using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Max_NormalList_ReturnsMax()
        {
            List<int> nums = new List<int> { 3, 7, 2, 9, 5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            int result = Operations.Max(null);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void Max_SingleElement_ReturnsElement()
        {
            List<int> nums = new List<int> { 42 };
            int result = Operations.Max(nums);
            Assert.AreEqual(42, result);
        }

        [Test]
        public void Max_NegativeNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -10, -5, -20, -3 };
            int result = Operations.Max(nums);
            Assert.AreEqual(-3, result);
        }

        [Test]
        public void Max_MixedNumbers_ReturnsMax()
        {
            List<int> nums = new List<int> { -5, 0, 10, -3, 7 };
            int result = Operations.Max(nums);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Max_AllSameValue_ReturnsValue()
        {
            List<int> nums = new List<int> { 5, 5, 5, 5 };
            int result = Operations.Max(nums);
            Assert.AreEqual(5, result);
        }
    }
}
