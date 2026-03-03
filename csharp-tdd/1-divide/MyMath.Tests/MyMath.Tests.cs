using NUnit.Framework;
using System;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Divide_NormalMatrix_ReturnsCorrectResult()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 2);
            int[,] expected = { { 5, 10 }, { 15, 20 } };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_MatrixByOne_ReturnsSameValues()
        {
            int[,] matrix = { { 5, 10 }, { 15, 20 } };
            int[,] result = Matrix.Divide(matrix, 1);
            int[,] expected = { { 5, 10 }, { 15, 20 } };

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 5);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int[,] result = Matrix.Divide(matrix, 0);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_ByZero_PrintsMessage()
        {
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            var originalOut = Console.Out;
            
            try
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    Matrix.Divide(matrix, 0);
                    string output = sw.ToString().Trim();
                    Assert.AreEqual("Num cannot be 0", output);
                }
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }

        [Test]
        public void Divide_3x3Matrix_ReturnsCorrectResult()
        {
            int[,] matrix = { { 9, 18, 27 }, { 36, 45, 54 }, { 63, 72, 81 } };
            int[,] result = Matrix.Divide(matrix, 9);
            int[,] expected = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            Assert.AreEqual(expected, result);
        }
    }
}
