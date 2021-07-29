using NUnit.Framework;
using System.IO;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void DivisionByInteger()
        {
            int[,] matrix = {
                {2, 4},
                {6, 8}
            };
            int num = 2;
            int[,] expected = {
                {1, 2},
                {3, 4}
            };

            int[,] result = Matrix.Divide(matrix, num);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void DivisionByZero()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                System.Console.SetOut(stringWriter);
                int[,] matrix = {
                    {2, 4},
                    {6, 8}
                };
                int num = 0;
                string expected = "Num cannot be 0\n";

                int[,] result = Matrix.Divide(matrix, num);

                Assert.AreEqual(expected, stringWriter.ToString());
                Assert.AreEqual(result, null);
            }
        }

        [Test]
        public void DivisionNullMatrix()
        {
            int[,] matrix = null;
            int num = 5;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(result, null);
        }

        [Test]
        public void EmptyMatrix()
        {
            int[,] matrix = {};
            int num = 2;
            int[,] result = Matrix.Divide(matrix, num);
            Assert.AreEqual(result, matrix);
        }
    }
}
