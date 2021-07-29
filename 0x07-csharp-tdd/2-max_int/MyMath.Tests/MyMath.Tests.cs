using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
            Assert.AreEqual(result, nums.Max());
        }

        [Test]
        public void UnsortedList()
        {
            List<int> nums = new List<int>{ 2, 1, 6, 4, 7, 1, 98, 23, 93 };
            int result = Operations.Max(nums);
            Assert.AreEqual(result, nums.Max());
        }

        [Test]
        public void EmptyList()
        {
            List<int> nums = new List<int>();
            int result = Operations.Max(nums);
            Assert.AreEqual(result, 0);
        }
    }
}
