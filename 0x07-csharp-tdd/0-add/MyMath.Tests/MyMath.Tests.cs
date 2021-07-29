using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void twoInteger([Values(1, 2, 3)] int a, [Values(1, 2, 3)] int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(result, a + b);
        }

        [Test]
        public void negativeIntegers([Values(-1, -2, -3)] int a, [Values(-1, -2, -3)] int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(result, a + b);
        }
    }
}
