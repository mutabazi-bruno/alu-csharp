using NUnit.Framework;

namespace MyMath.Tests
{
    /// <summary>
    /// Test class for Operations.
    /// </summary>
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Test adding two positive numbers.
        /// </summary>
        [Test]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            int result = Operations.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        /// <summary>
        /// Test adding two negative numbers.
        /// </summary>
        [Test]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            int result = Operations.Add(-5, -3);
            Assert.AreEqual(-8, result);
        }

        /// <summary>
        /// Test adding a positive and negative number.
        /// </summary>
        [Test]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            int result = Operations.Add(5, -3);
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Test adding zero.
        /// </summary>
        [Test]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            int result = Operations.Add(5, 0);
            Assert.AreEqual(5, result);
        }

        /// <summary>
        /// Test adding two zeros.
        /// </summary>
        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            int result = Operations.Add(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}
