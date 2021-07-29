using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void SortedList()
        {
            List<int> nums = new List<int>{ 1, 2, 3, 4, 5, 6 };
            int result = Operations.Max(nums);
            Assert.AreEqual(result, 6);
        }

        [Test]
        public void UnsortedList()
        {
            List<int> nums = new List<int>{ 2, 1, 6, 4, 7, 1, 98, 23, 93 };
            int result = Operations.Max(nums);
            Assert.AreEqual(result, 98);
        }

        [Test]
        public void EmptyList()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void LengthOneList()
        {
            List<int> nums = new List<int>{ 90 };
            int result = Operations.Max(nums);
            Assert.AreEqual(result, 90);
        }

        [Test]
        public void MultpleMaximuns()
        {
            List<int> nums = new List<int>{ 23, 23, 23, 2, 22, 10 };
            int result = Operations.Max(nums);
            Assert.AreEqual(result, 23);
        }

        [Test]
        public void NegativeIntegers()
        {
            List<int> nums = new List<int>{ -50, -48, -100, -999, -5};
            int result = Operations.Max(nums);
            Assert.AreEqual(result, -5);
        }
    }
}
